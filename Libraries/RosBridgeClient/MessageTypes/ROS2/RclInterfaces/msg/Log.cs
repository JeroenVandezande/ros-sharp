/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.BuiltinInterfaces;

namespace RosSharp.RosBridgeClient.MessageTypes.RclInterfaces
{
    public class Log : Message
    {
        public const string RosMessageName = "rcl_interfaces/msg/Log";

        // #
        // # Severity level constants
        // # 
        // # These logging levels follow the Python Standard
        // # https://docs.python.org/3/library/logging.html#logging-levels
        // # And are implemented in rcutils as well
        // # https://github.com/ros2/rcutils/blob/35f29850064e0c33a4063cbc947ebbfeada11dba/include/rcutils/logging.h#L164-L172
        // # This leaves space for other standard logging levels to be inserted in the middle in the future,
        // # as well as custom user defined levels.
        // # Since there are several other logging enumeration standard for different implementations,
        // # other logging implementations may need to provide level mappings to match their internal implementations.
        // #
        //  Debug is for pedantic information, which is useful when debugging issues.
        public const byte DEBUG = 10;
        //  Info is the standard informational level and is used to report expected
        //  information.
        public const byte INFO = 20;
        //  Warning is for information that may potentially cause issues or possibly unexpected
        //  behavior.
        public const byte WARN = 30;
        //  Error is for information that this node cannot resolve.
        public const byte ERROR = 40;
        //  Information about a impending node shutdown.
        public const byte FATAL = 50;
        // #
        // # Fields
        // #
        //  Timestamp when this message was generated by the node.
        public Time stamp { get; set; }
        //  Corresponding log level, see above definitions.
        public byte level { get; set; }
        //  The name representing the logger this message came from.
        public string name { get; set; }
        //  The full log message.
        public string msg { get; set; }
        //  The file the message came from.
        public string file { get; set; }
        //  The function the message came from.
        public string function { get; set; }
        //  The line in the file the message came from.
        public uint line { get; set; }

        public Log()
        {
            this.stamp = new Time();
            this.level = 0;
            this.name = "";
            this.msg = "";
            this.file = "";
            this.function = "";
            this.line = 0;
        }

        public Log(Time stamp, byte level, string name, string msg, string file, string function, uint line)
        {
            this.stamp = stamp;
            this.level = level;
            this.name = name;
            this.msg = msg;
            this.file = file;
            this.function = function;
            this.line = line;
        }
    }
}
#endif
