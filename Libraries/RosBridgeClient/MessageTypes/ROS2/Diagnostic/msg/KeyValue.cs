/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Diagnostic
{
    public class KeyValue : Message
    {
        public const string RosMessageName = "diagnostic_msgs/msg/KeyValue";

        //  What to label this value when viewing.
        public string key { get; set; }
        //  A value to track over time.
        public string value { get; set; }

        public KeyValue()
        {
            this.key = "";
            this.value = "";
        }

        public KeyValue(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
#endif
