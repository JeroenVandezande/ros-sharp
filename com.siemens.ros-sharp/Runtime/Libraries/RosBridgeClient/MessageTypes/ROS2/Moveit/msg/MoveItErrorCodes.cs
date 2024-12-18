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
    public class MoveItErrorCodes : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/MoveItErrorCodes";

        public int val { get; set; }
        //  overall behavior
        public const int SUCCESS = 1;
        public const int UNDEFINED = 0;
        public const int FAILURE = 99999;
        public const int PLANNING_FAILED = -1;
        public const int INVALID_MOTION_PLAN = -2;
        public const int MOTION_PLAN_INVALIDATED_BY_ENVIRONMENT_CHANGE = -3;
        public const int CONTROL_FAILED = -4;
        public const int UNABLE_TO_AQUIRE_SENSOR_DATA = -5;
        public const int TIMED_OUT = -6;
        public const int PREEMPTED = -7;
        //  planning & kinematics request errors
        public const int START_STATE_IN_COLLISION = -10;
        public const int START_STATE_VIOLATES_PATH_CONSTRAINTS = -11;
        public const int START_STATE_INVALID = -26;
        public const int GOAL_IN_COLLISION = -12;
        public const int GOAL_VIOLATES_PATH_CONSTRAINTS = -13;
        public const int GOAL_CONSTRAINTS_VIOLATED = -14;
        public const int GOAL_STATE_INVALID = -27;
        public const int UNRECOGNIZED_GOAL_TYPE = -28;
        public const int INVALID_GROUP_NAME = -15;
        public const int INVALID_GOAL_CONSTRAINTS = -16;
        public const int INVALID_ROBOT_STATE = -17;
        public const int INVALID_LINK_NAME = -18;
        public const int INVALID_OBJECT_NAME = -19;
        //  system errors
        public const int FRAME_TRANSFORM_FAILURE = -21;
        public const int COLLISION_CHECKING_UNAVAILABLE = -22;
        public const int ROBOT_STATE_STALE = -23;
        public const int SENSOR_INFO_STALE = -24;
        public const int COMMUNICATION_FAILURE = -25;
        public const int CRASH = -29;
        public const int ABORT = -30;
        //  kinematics errors
        public const int NO_IK_SOLUTION = -31;
        //  A message to provide additional information.
        public string message { get; set; }
        //  Name of the component that created the status.
        //  This is helpful to locate error source.
        public string source { get; set; }

        public MoveItErrorCodes()
        {
            this.val = 0;
            this.message = "";
            this.source = "";
        }

        public MoveItErrorCodes(int val, string message, string source)
        {
            this.val = val;
            this.message = message;
            this.source = source;
        }
    }
}
#endif
