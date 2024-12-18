/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Rosbridge
{
    public class ConnectedClients : Message
    {
        public const string RosMessageName = "rosbridge_msgs/msg/ConnectedClients";

        public ConnectedClient[] clients { get; set; }

        public ConnectedClients()
        {
            this.clients = new ConnectedClient[0];
        }

        public ConnectedClients(ConnectedClient[] clients)
        {
            this.clients = clients;
        }
    }
}
#endif
