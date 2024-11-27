/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.BuiltinInterfaces
{
    public class Duration : Message
    {
        public const string RosMessageName = "builtin_interfaces/msg/Duration";

        //  Duration defines a period between two time points.
        //  Messages of this datatype are of ROS Time following this design:
        //  https://design.ros2.org/articles/clock_and_time.html
        //  Seconds component, range is valid over any possible int32 value.
        public int sec { get; set; }
        //  Nanoseconds component in the range of [0, 1e9).
        public uint nanosec { get; set; }

        public Duration()
        {
            this.sec = 0;
            this.nanosec = 0;
        }

        public Duration(int sec, uint nanosec)
        {
            this.sec = sec;
            this.nanosec = nanosec;
        }
    }
}
#endif
