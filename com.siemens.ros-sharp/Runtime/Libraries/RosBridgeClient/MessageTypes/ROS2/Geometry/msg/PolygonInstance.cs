/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class PolygonInstance : Message
    {
        public const string RosMessageName = "geometry_msgs/msg/PolygonInstance";

        //  A specification of a polygon where the first and last points are assumed to be connected
        //  It includes a unique identification field for disambiguating multiple instances
        public Polygon polygon { get; set; }
        public long id { get; set; }

        public PolygonInstance()
        {
            this.polygon = new Polygon();
            this.id = 0;
        }

        public PolygonInstance(Polygon polygon, long id)
        {
            this.polygon = polygon;
            this.id = id;
        }
    }
}
#endif