/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.RclInterfaces
{
    public class ParameterType : Message
    {
        public const string RosMessageName = "rcl_interfaces/msg/ParameterType";

        //  These types correspond to the value that is set in the ParameterValue message.
        //  Default value, which implies this is not a valid parameter.
        public const byte PARAMETER_NOT_SET = 0;
        public const byte PARAMETER_BOOL = 1;
        public const byte PARAMETER_INTEGER = 2;
        public const byte PARAMETER_DOUBLE = 3;
        public const byte PARAMETER_STRING = 4;
        public const byte PARAMETER_BYTE_ARRAY = 5;
        public const byte PARAMETER_BOOL_ARRAY = 6;
        public const byte PARAMETER_INTEGER_ARRAY = 7;
        public const byte PARAMETER_DOUBLE_ARRAY = 8;
        public const byte PARAMETER_STRING_ARRAY = 9;

        public ParameterType()
        {
        }
    }
}
#endif