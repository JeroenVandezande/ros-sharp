/*
© Siemens AG, 2019
Author: Sifan Ye (sifan.ye@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.IO;
using System.Collections.Generic;

namespace RosSharp.RosBridgeClient.MessageGeneration
{
    public class MessageTokenizer {

        private string inFilePath = "";
        private uint lineNum = 1;

        private StreamReader reader;

        private readonly HashSet<string> builtInTypes;

        private readonly HashSet<char> allowedSpecialCharacterForTypeIdentifier = new HashSet<char>()
        { '_', '/'};

        public MessageTokenizer(string inFilePath, HashSet<string> builtInTypes) {
            this.inFilePath = inFilePath;
            this.reader = new StreamReader(inFilePath);
            this.builtInTypes = builtInTypes;
        }

        /// <summary>
        /// Tokenizes the stream input
        /// </summary>
        /// <returns> A list of MessageTokens read from the stream </returns>
        public List<List<MessageToken>> Tokenize() {

            List<List<MessageToken>> listsOfTokens = new List<List<MessageToken>>();

            listsOfTokens.Add(new List<MessageToken>());
            int listIndex = 0;

            // Information about the original file
            listsOfTokens[0].Add(new MessageToken(MessageTokenType.FilePath, inFilePath, 0));

            while (!reader.EndOfStream)
            {
                DiscardEmpty();
                if (reader.EndOfStream) {
                    break;
                }
                if (reader.Peek() == '\n') {
                    // If line is empty, move on
                    reader.Read();
                    lineNum++;
                    continue;
                }
                else if (reader.Peek() == '\r')
                {
                    // CRLF new line for Windows
                    reader.Read();
                    if (reader.Peek() == '\n')
                    {
                        reader.Read();
                        lineNum++;
                    }
                    continue;
                }
                else if (reader.Peek() == '#')
                {
                    // A line that starts with a '#' is a comment
                    listsOfTokens[listIndex].Add(NextCommentToken());
                }
                else if (reader.Peek() == '-')
                {
                    // Seperator ---
                    NextSeperator();
                    listsOfTokens.Add(new List<MessageToken>());
                    listIndex++;
                    listsOfTokens[listIndex].Add(new MessageToken(MessageTokenType.FilePath, inFilePath, 0));
                }
                else
                {
                    // Otherwise a declaration
                    // Note that a string constant line cannot have comment

                    // Line always start with a type
                    // Type can be built-in, defined, list, or Header
                    listsOfTokens[listIndex].Add(NextTypeIdentifierToken());

                    // If peek shows '[', the type is a list/array
                    if (reader.Peek() == '[')
                    {
                        listsOfTokens[listIndex].Add(NextArrayDeclaration());
                    }
                    
                    // If peek shows '<', this mean there is a size restriction, we will ignore that
                    if (reader.Peek() == '<')
                    {
                        reader.Read(); //ignore char
                        if (reader.Peek() == '=')
                        {
                            reader.Read(); //ignore char
                        }
                        while (Char.IsNumber((Char)reader.Peek())) //read the number of the size restriction
                        {
                            reader.Read(); //ignore char
                        }
                    }
                    DiscardEmpty();

                    // Then, field identifier
                    listsOfTokens[listIndex].Add(NextIdentifierToken());
                    DiscardEmpty();

                    // A constant may be declared
                    if (reader.Peek() == '=') {
                        listsOfTokens[listIndex].Add(NextConstantDeclaration());
                    }

                    // Optionally, the line may have a comment line
                    if (reader.Peek() == '#')
                    {
                        listsOfTokens[listIndex].Add(NextCommentToken(false));
                    }
                    //the default value of the field
                    else if (!Char.IsWhiteSpace((Char)reader.Peek()))
                    {
                        var fdv = NextFieldDefaultValue();
                        if (fdv != null)
                        {
                            listsOfTokens[listIndex].Add(fdv);
                            if (reader.Peek() == '#')
                            {
                                listsOfTokens[listIndex].Add(NextCommentToken(false));
                            }
                        }
                    }
                    else
                    {
                        // The line ends with spaces to be discarded and a '\n'
                        DiscardEmpty();
                        if (reader.Peek() == '\n')
                        {
                            reader.Read();
                            lineNum++;
                        }
                        else if (reader.Peek() == '\r')
                        {
                            // CRLF new line for Windows
                            reader.Read();
                            if (reader.Peek() == '\n')
                            {
                                reader.Read();
                                lineNum++;
                            }
                        }
                        else if (!reader.EndOfStream)
                        {
                            throw new MessageTokenizerException(
                                "Invalid token: " + NextTokenStr() +
                                ". New line or EOF expected " + CurrentFileAndLine());
                        }
                    }
                }
            }

            reader.Close();
            reader.Dispose();
            return listsOfTokens;
        }

        /// <summary>
        /// Read and discards empty spaces
        /// Empty spaces include ' ' and '\t'
        /// </summary>
        private void DiscardEmpty()
        {
            while (reader.Peek() == ' ' || reader.Peek() == '\t')
            {
                reader.Read();
            }
        }

        /// <summary>
        /// Read until '\n' and return all content before '\n'
        /// Removes start and end trailing spaces
        /// </summary>
        /// <returns> All content before '\n' </returns>
        private string ReadUntilNewLineAndTrim() {
            string content = "";
            while (reader.Peek() != '\n' && reader.Peek() != '#' && !reader.EndOfStream) {
                if (reader.Peek() != '\r')
                {
                    content += (char)reader.Read();
                }
                else
                {
                    // Discard carriage return
                    reader.Read();
                }
            }
            content.Trim();
            return content;
        }

        /// <summary>
        /// Returns the next token string
        /// Tokens are seperated by whitespace (" " or "\n")
        /// </summary>
        /// <returns> Next token string in the stream </returns>
        private string NextTokenStr()
        {
            string token = "";
            while (reader.Peek() != ' ' && reader.Peek() != '\n' && !reader.EndOfStream)
            {
                if (reader.Peek() != '\r')
                {
                    token += (char)reader.Read();
                }
                else
                {
                    // Discard carriage return
                    reader.Read();
                }
            }
            reader.Read();
            return token;
        }

        /// <summary>
        /// Returns the next comment token
        /// A comment is defined as "# sigma* \n"
        /// Assumes a '#' has been peeked
        /// </summary>
        /// <returns> Next comment token in the stream </returns>
        private MessageToken NextCommentToken(bool onSameLine = false)
        {
            reader.Read(); // Discard '#'

            string comment = "";
            while (reader.Peek() != '\n' && !reader.EndOfStream)
            {
                if (reader.Peek() != '\r')
                {
                    comment += (char)reader.Read();
                }
                else
                {
                    // Discard carriage return
                    reader.Read();
                }
            }
            reader.Read();
            lineNum++;
            return new MessageToken(MessageTokenType.Comment, comment, onSameLine ? lineNum : lineNum - 1);
        }

        /// <summary>
        /// Returns the next ROS Service/Action seperator
        /// Only allows "---" on its own line
        /// </summary>
        /// <returns> Next seperator token in the stream </returns>
        private MessageToken NextSeperator() {
            string token = ReadUntilNewLineAndTrim();
            if (token.Equals("---"))
            {
                reader.Read();
                lineNum++;
                return new MessageToken(MessageTokenType.Seperator, token, lineNum - 1);
            }
            else {
                throw new MessageTokenizerException("Unexpected token '" + token + "'. Did you mean '---' (ROS Service/Action seperator)?");
            }
        }
        
        /// <summary>
        /// Returns the next type identifier token
        /// Type identifiers start with an alphabet and can contain _ and /
        /// Array notation is considered a seperate token
        /// </summary>
        /// <returns> Next type identifer token in the stream </returns>
        private MessageToken NextTypeIdentifierToken()
        {
            string tokenStr = "";

            // If start char is not alphabet, identifier invalid
            if (!Char.IsLetter((char)reader.Peek()))
            {
                throw new MessageTokenizerException("Invalid type identifier: " + NextTokenStr() + " " + CurrentFileAndLine());
            }

            // Otherwise, consume input until seperator, EOF or '['
            while (reader.Peek() != ' ' && reader.Peek() != '[' && reader.Peek() != '<' && !reader.EndOfStream)
            {
                if (!Char.IsLetterOrDigit((char)reader.Peek()) && !allowedSpecialCharacterForTypeIdentifier.Contains((char)reader.Peek())) {
                    throw new MessageTokenizerException("Invalid character in type identifier: " + (char)reader.Peek() + " " + CurrentFileAndLine());
                }
                tokenStr += (char)reader.Read();
            }

            if (builtInTypes.Contains(tokenStr))
            {
                return new MessageToken(MessageTokenType.BuiltInType, tokenStr, lineNum);
            }
            else if (tokenStr.Equals("Header"))
            {
                return new MessageToken(MessageTokenType.Header, tokenStr, lineNum);
            }
            else
            {
                return new MessageToken(MessageTokenType.DefinedType, tokenStr, lineNum);
            }
        }

        /// <summary>
        /// Returns the next array declaration
        /// Array declarations are defined as [] or [number]
        /// Assumes that '[' has been peeked
        /// </summary>
        /// <returns> Next array declaration token in the stream </returns>
        private MessageToken NextArrayDeclaration()
        {
            string tokenStr = "";

            reader.Read(); // Discard '['

            if (reader.Peek() == ']')
            {
                reader.Read(); // Discard ']'
                if (reader.Peek() != ' ')
                {
                    throw new MessageTokenizerException("Invalid character '" + (char)reader.Peek() + "' after ']'" + " " + CurrentFileAndLine());
                }
                return new MessageToken(MessageTokenType.VariableSizeArray, "", lineNum);
            }
            else
            {
                string arraySizeStr = "";
                if (reader.Peek() == '<') // Discard <
                {
                    reader.Read();
                }
                if (reader.Peek() == '=') // Discard =
                {
                    reader.Read();
                }
                while (reader.Peek() != ']')
                {
                    arraySizeStr += (char)reader.Read();
                }
                uint arraySize = 0;
                if (uint.TryParse(arraySizeStr, out arraySize))
                {
                    tokenStr += arraySize;
                }
                else {
                    // Invalid Array Declaration
                    throw new MessageTokenizerException("Invalid array declaration: [" + arraySizeStr + "] " + CurrentFileAndLine());
                }

                reader.Read(); // Discard ']'

                if (reader.Peek() != ' ')
                {
                    throw new MessageTokenizerException("Invalid character '" + (char)reader.Peek() + "' after ']'" + " " + CurrentFileAndLine());
                }
                return new MessageToken(MessageTokenType.FixedSizeArray, tokenStr, lineNum);
            }
        }

        private string EscapeTokenString(string token)
        {
            switch (token.ToLower())
            {
                case "object":
                {
                    return "@object";
                    break;
                }
                default:
                {
                    return token;
                }
                
            }
            
        }
        private string _lastTokenName;
        /// <summary>
        /// Returns the next field identifier token
        /// Field identifiers can only start with an alphabet
        /// </summary>
        /// <returns> Next field identifier token in the stream </returns>
        private MessageToken NextIdentifierToken()
        {
            string tokenStr = "";

            // If start char is not alphabet, identifier invalid
            if (!Char.IsLetter((char)reader.Peek()))
            {
                throw new MessageTokenizerException("Invalid identifier: " + NextTokenStr() + " " + CurrentFileAndLine());
            }

            // Otherwise, consume input until seperator or EOF
            while (reader.Peek() != ' ' && reader.Peek() != '\n' && reader.Peek() != '=' && !reader.EndOfStream)
            {
                if (reader.Peek() == '\r')
                {
                    reader.Read();
                    continue;
                }
                if (!Char.IsLetterOrDigit((char)reader.Peek()) && reader.Peek() != '_')
                {
                    {
                        throw new MessageTokenizerException("Invalid character in identifier: " + (char)reader.Peek() + " " + CurrentFileAndLine());
                    }
                }
                tokenStr += (char)reader.Read();
            }

            _lastTokenName = tokenStr;
            return new MessageToken(MessageTokenType.Identifier, EscapeTokenString(tokenStr), lineNum);
        }

        /// <summary>
        /// Returns the next constant declaration
        /// Will decide declaration type
        /// Assumes that '=' has been peeked
        /// </summary>
        /// <returns></returns>
        private MessageToken NextConstantDeclaration()
        {
            reader.Read();

            string val = ReadUntilNewLineAndTrim();
            
            if (_lastTokenName.ToUpper() == _lastTokenName)
            {
                return new MessageToken(MessageTokenType.ConstantDeclaration, val, lineNum);
            }
            else
            {
                return new MessageToken(MessageTokenType.FieldDefaultValue, val, lineNum);
            }
        }
        
        private MessageToken NextFieldDefaultValue()
        {
            string val = ReadUntilNewLineAndTrim();
            if (string.IsNullOrEmpty(val)) return null;
            return new MessageToken(MessageTokenType.FieldDefaultValue, val, lineNum);
        }


        /// <summary>
        /// Returns the current file path and line number
        /// </summary>
        /// <returns> Returns the current file path and line number </returns>
        private string CurrentFileAndLine() {
            return "(" + this.inFilePath + ":" + lineNum + ")";
        }

    }

    public class MessageTokenizerException : Exception
    {
        public MessageTokenizerException(string msg) : base(msg) { }
    }
}