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
    public class IntegerRange : Message
    {
        public const string RosMessageName = "rcl_interfaces/msg/IntegerRange";

        //  Represents bounds and a step value for an integer typed parameter.
        //  Start value for valid values, inclusive.
        public long from_value { get; set; }
        //  End value for valid values, inclusive.
        public long to_value { get; set; }
        //  Size of valid steps between the from and to bound.
        // 
        //  A step value of zero implies a continuous range of values. Ideally, the step
        //  would be less than or equal to the distance between the bounds, as well as an
        //  even multiple of the distance between the bounds, but neither are required.
        // 
        //  If the absolute value of the step is larger than or equal to the distance
        //  between the two bounds, then the bounds will be the only valid values. e.g. if
        //  the range is defined as {from_value: 1, to_value: 2, step: 5} then the valid
        //  values will be 1 and 2.
        //  
        //  If the step is less than the distance between the bounds, but the distance is
        //  not a multiple of the step, then the "to" bound will always be a valid value,
        //  e.g. if the range is defined as {from_value: 2, to_value: 5, step: 2} then
        //  the valid values will be 2, 4, and 5.
        public ulong step { get; set; }

        public IntegerRange()
        {
            this.from_value = 0;
            this.to_value = 0;
            this.step = 0;
        }

        public IntegerRange(long from_value, long to_value, ulong step)
        {
            this.from_value = from_value;
            this.to_value = to_value;
            this.step = step;
        }
    }
}
#endif
