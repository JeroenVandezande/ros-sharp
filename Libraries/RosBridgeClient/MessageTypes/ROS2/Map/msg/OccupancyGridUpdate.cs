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

namespace RosSharp.RosBridgeClient.MessageTypes.Map
{
    public class OccupancyGridUpdate : Message
    {
        public const string RosMessageName = "map_msgs/msg/OccupancyGridUpdate";

        public Header header { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public uint width { get; set; }
        public uint height { get; set; }
        public sbyte[] data { get; set; }

        public OccupancyGridUpdate()
        {
            this.header = new Header();
            this.x = 0;
            this.y = 0;
            this.width = 0;
            this.height = 0;
            this.data = new sbyte[0];
        }

        public OccupancyGridUpdate(Header header, int x, int y, uint width, uint height, sbyte[] data)
        {
            this.header = header;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.data = data;
        }
    }
}
#endif