/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class ServoStatus : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/ServoStatus";

        //  Message
        public sbyte code { get; set; }
        //  will contains integer code
        public string message { get; set; }
        //  will contain explanatory message
        //  Status types (should reflect StatusCode from moveit_servo/utils/datatype.hpp)
        public const sbyte INVALID = -1;
        public const sbyte NO_WARNING = 0;
        public const sbyte DECELERATE_FOR_APPROACHING_SINGULARITY = 1;
        public const sbyte HALT_FOR_SINGULARITY = 2;
        public const sbyte DECELERATE_FOR_LEAVING_SINGULARITY = 3;
        public const sbyte DECELERATE_FOR_COLLISION = 4;
        public const sbyte HALT_FOR_COLLISION = 5;
        public const sbyte JOINT_BOUND = 6;

        public ServoStatus()
        {
            this.code = 0;
            this.message = "";
        }

        public ServoStatus(sbyte code, string message)
        {
            this.code = code;
            this.message = message;
        }
    }
}
#endif
