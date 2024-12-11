/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Pcl
{
    public class PointIndices : Message
    {
        public const string RosMessageName = "pcl_msgs/msg/PointIndices";

        public Header header { get; set; }
        public int[] indices { get; set; }

        public PointIndices()
        {
            this.header = new Header();
            this.indices = new int[0];
        }

        public PointIndices(Header header, int[] indices)
        {
            this.header = header;
            this.indices = indices;
        }
    }
}
#endif