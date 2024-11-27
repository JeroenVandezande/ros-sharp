/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Rosbag2Interfaces
{
    public class ReadSplitEvent : Message
    {
        public const string RosMessageName = "rosbag2_interfaces/msg/ReadSplitEvent";

        //  The full path of the file that was finished and closed
        public string closed_file { get; set; }
        //  The full path of the new file that was opened to continue playback
        public string opened_file { get; set; }
        //  The fully qualified node name of the event sender
        public string node_name { get; set; }

        public ReadSplitEvent()
        {
            this.closed_file = "";
            this.opened_file = "";
            this.node_name = "";
        }

        public ReadSplitEvent(string closed_file, string opened_file, string node_name)
        {
            this.closed_file = closed_file;
            this.opened_file = opened_file;
            this.node_name = node_name;
        }
    }
}
#endif
