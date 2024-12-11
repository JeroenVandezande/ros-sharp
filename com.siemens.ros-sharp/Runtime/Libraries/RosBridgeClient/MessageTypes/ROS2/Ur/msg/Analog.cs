/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Ur
{
    public class Analog : Message
    {
        public const string RosMessageName = "ur_msgs/msg/Analog";

        public const byte CURRENT = 0;
        public const byte VOLTAGE = 1;
        public byte pin { get; set; }
        public byte domain { get; set; }
        //  can be VOLTAGE or CURRENT
        public float state { get; set; }

        public Analog()
        {
            this.pin = 0;
            this.domain = 0;
            this.state = 0.0f;
        }

        public Analog(byte pin, byte domain, float state)
        {
            this.pin = pin;
            this.domain = domain;
            this.state = state;
        }
    }
}
#endif