/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.Trajectory;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class AttachedCollisionObject : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/AttachedCollisionObject";

        //  The CollisionObject will be attached with a fixed joint to this link
        public string link_name { get; set; }
        // This contains the actual shapes and poses for the CollisionObject
        // to be attached to the link
        // If action is remove and no object.id is set, all objects
        // attached to the link indicated by link_name will be removed
        public CollisionObject @object { get; set; }
        //  The set of links that the attached objects are allowed to touch
        //  by default - the link_name is already considered by default
        public string[] touch_links { get; set; }
        //  If certain links were placed in a particular posture for this object to remain attached
        //  (e.g., an end effector closing around an object), the posture necessary for releasing
        //  the object is stored here
        public JointTrajectory detach_posture { get; set; }
        //  The weight of the attached object, if known
        public double weight { get; set; }

        public AttachedCollisionObject()
        {
            this.link_name = "";
            this.@object = new CollisionObject();
            this.touch_links = new string[0];
            this.detach_posture = new JointTrajectory();
            this.weight = 0.0;
        }

        public AttachedCollisionObject(string link_name, CollisionObject @object, string[] touch_links, JointTrajectory detach_posture, double weight)
        {
            this.link_name = link_name;
            this.@object = @object;
            this.touch_links = touch_links;
            this.detach_posture = detach_posture;
            this.weight = weight;
        }
    }
}
#endif
