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
    public class GetMotionPlan_Request : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/GetMotionPlan_Request";

        //  This service contains the definition for a request to the motion
        //  planner and the output it provides
        public MotionPlanRequest motion_plan_request { get; set; }

        public GetMotionPlan_Request()
        {
            this.motion_plan_request = new MotionPlanRequest();
        }

        public GetMotionPlan_Request(MotionPlanRequest motion_plan_request)
        {
            this.motion_plan_request = motion_plan_request;
        }
    }
}
#endif