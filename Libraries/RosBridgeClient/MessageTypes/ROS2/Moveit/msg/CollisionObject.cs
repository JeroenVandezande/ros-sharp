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
using RosSharp.RosBridgeClient.MessageTypes.ObjectRecognition;
using RosSharp.RosBridgeClient.MessageTypes.Shape;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class CollisionObject : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/CollisionObject";

        //  a header, used for interpreting the poses
        public Header header { get; set; }
        //  The object's pose relative to the header frame.
        //  The shapes and subframe poses are defined relative to this pose.
        public Pose pose { get; set; }
        //  The id of the object (name used in MoveIt)
        public string id { get; set; }
        //  The object type in a database of known objects
        public ObjectType type { get; set; }
        //  The collision geometries associated with the object.
        //  Their poses are with respect to the object's pose
        //  Solid geometric primitives
        public SolidPrimitive[] primitives { get; set; }
        public Pose[] primitive_poses { get; set; }
        //  Meshes
        public Mesh[] meshes { get; set; }
        public Pose[] mesh_poses { get; set; }
        //  Bounding planes (equation is specified, but the plane can be oriented using an additional pose)
        public Plane[] planes { get; set; }
        public Pose[] plane_poses { get; set; }
        //  Named subframes on the object. Use these to define points of interest on the object that you want
        //  to plan with (e.g. "tip", "spout", "handle"). The id of the object will be prepended to the subframe.
        //  If an object with the id "screwdriver" and a subframe "tip" is in the scene, you can use the frame
        //  "screwdriver/tip" for planning.
        //  The length of the subframe_names and subframe_poses has to be identical.
        public string[] subframe_names { get; set; }
        public Pose[] subframe_poses { get; set; }
        //  Adds the object to the planning scene. If the object previously existed, it is replaced.
        public const sbyte ADD = 0;
        //  Removes the object from the environment entirely (everything that matches the specified id)
        public const sbyte REMOVE = 1;
        //  Append to an object that already exists in the planning scene. If the object does not exist, it is added.
        public const sbyte APPEND = 2;
        //  If an object already exists in the scene, new poses can be sent (the geometry arrays must be left empty)
        //  if solely moving the object is desired
        public const sbyte MOVE = 3;
        //  Operation to be performed
        public sbyte operation { get; set; }

        public CollisionObject()
        {
            this.header = new Header();
            this.pose = new Pose();
            this.id = "";
            this.type = new ObjectType();
            this.primitives = new SolidPrimitive[0];
            this.primitive_poses = new Pose[0];
            this.meshes = new Mesh[0];
            this.mesh_poses = new Pose[0];
            this.planes = new Plane[0];
            this.plane_poses = new Pose[0];
            this.subframe_names = new string[0];
            this.subframe_poses = new Pose[0];
            this.operation = 0;
        }

        public CollisionObject(Header header, Pose pose, string id, ObjectType type, SolidPrimitive[] primitives, Pose[] primitive_poses, Mesh[] meshes, Pose[] mesh_poses, Plane[] planes, Pose[] plane_poses, string[] subframe_names, Pose[] subframe_poses, sbyte operation)
        {
            this.header = header;
            this.pose = pose;
            this.id = id;
            this.type = type;
            this.primitives = primitives;
            this.primitive_poses = primitive_poses;
            this.meshes = meshes;
            this.mesh_poses = mesh_poses;
            this.planes = planes;
            this.plane_poses = plane_poses;
            this.subframe_names = subframe_names;
            this.subframe_poses = subframe_poses;
            this.operation = operation;
        }
    }
}
#endif
