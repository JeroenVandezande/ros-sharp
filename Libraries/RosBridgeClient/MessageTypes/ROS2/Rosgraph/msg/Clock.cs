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

namespace RosSharp.RosBridgeClient.MessageTypes.Rosgraph
{
    public class Clock : Message
    {
        public const string RosMessageName = "rosgraph_msgs/msg/Clock";

        //  This message communicates the current time.
        // 
        //  For more information, see https://design.ros2.org/articles/clock_and_time.html.
        public Time clock { get; set; }

        public Clock()
        {
            this.clock = new Time();
        }

        public Clock(Time clock)
        {
            this.clock = clock;
        }
    }
}
#endif