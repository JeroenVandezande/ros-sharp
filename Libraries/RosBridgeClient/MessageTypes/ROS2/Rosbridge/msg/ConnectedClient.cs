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

namespace RosSharp.RosBridgeClient.MessageTypes.Rosbridge
{
    public class ConnectedClient : Message
    {
        public const string RosMessageName = "rosbridge_msgs/msg/ConnectedClient";

        public string ip_address { get; set; }
        public Time connection_time { get; set; }

        public ConnectedClient()
        {
            this.ip_address = "";
            this.connection_time = new Time();
        }

        public ConnectedClient(string ip_address, Time connection_time)
        {
            this.ip_address = ip_address;
            this.connection_time = connection_time;
        }
    }
}
#endif
