/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Map
{
    public class ProjectedMapInfo : Message
    {
        public const string RosMessageName = "map_msgs/msg/ProjectedMapInfo";

        public string frame_id { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double min_z { get; set; }
        public double max_z { get; set; }

        public ProjectedMapInfo()
        {
            this.frame_id = "";
            this.x = 0.0;
            this.y = 0.0;
            this.width = 0.0;
            this.height = 0.0;
            this.min_z = 0.0;
            this.max_z = 0.0;
        }

        public ProjectedMapInfo(string frame_id, double x, double y, double width, double height, double min_z, double max_z)
        {
            this.frame_id = frame_id;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.min_z = min_z;
            this.max_z = max_z;
        }
    }
}
#endif
