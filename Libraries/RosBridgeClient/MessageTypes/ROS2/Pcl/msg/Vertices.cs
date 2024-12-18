/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Pcl
{
    public class Vertices : Message
    {
        public const string RosMessageName = "pcl_msgs/msg/Vertices";

        //  List of point indices
        public uint[] vertices { get; set; }

        public Vertices()
        {
            this.vertices = new uint[0];
        }

        public Vertices(uint[] vertices)
        {
            this.vertices = vertices;
        }
    }
}
#endif
