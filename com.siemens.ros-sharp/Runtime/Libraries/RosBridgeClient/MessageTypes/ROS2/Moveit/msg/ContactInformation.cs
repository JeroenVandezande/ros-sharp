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
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class ContactInformation : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/ContactInformation";

        //  Standard ROS header contains information
        //  about the frame in which this
        //  contact is specified
        public Header header { get; set; }
        //  Position of the contact point
        public Point position { get; set; }
        //  Normal corresponding to the contact point
        public Vector3 normal { get; set; }
        //  Depth of contact point
        public double depth { get; set; }
        //  Name of the first body that is in contact
        //  This could be a link or a namespace that represents a body
        public string contact_body_1 { get; set; }
        public uint body_type_1 { get; set; }
        //  Name of the second body that is in contact
        //  This could be a link or a namespace that represents a body
        public string contact_body_2 { get; set; }
        public uint body_type_2 { get; set; }
        public const uint ROBOT_LINK = 0;
        public const uint WORLD_OBJECT = 1;
        public const uint ROBOT_ATTACHED = 2;

        public ContactInformation()
        {
            this.header = new Header();
            this.position = new Point();
            this.normal = new Vector3();
            this.depth = 0.0;
            this.contact_body_1 = "";
            this.body_type_1 = 0;
            this.contact_body_2 = "";
            this.body_type_2 = 0;
        }

        public ContactInformation(Header header, Point position, Vector3 normal, double depth, string contact_body_1, uint body_type_1, string contact_body_2, uint body_type_2)
        {
            this.header = header;
            this.position = position;
            this.normal = normal;
            this.depth = depth;
            this.contact_body_1 = contact_body_1;
            this.body_type_1 = body_type_1;
            this.contact_body_2 = contact_body_2;
            this.body_type_2 = body_type_2;
        }
    }
}
#endif
