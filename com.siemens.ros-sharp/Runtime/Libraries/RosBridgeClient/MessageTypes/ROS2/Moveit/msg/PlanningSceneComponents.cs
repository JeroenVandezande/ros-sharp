/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class PlanningSceneComponents : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/PlanningSceneComponents";

        //  This message defines the components that make up the PlanningScene message.
        //  The values can be used as a bitfield to specify which parts of the PlanningScene message
        //  are of interest
        //  Scene name, model name, model root
        public const uint SCENE_SETTINGS = 1;
        //  Joint values of the robot state
        public const uint ROBOT_STATE = 2;
        //  Attached objects (including geometry) for the robot state
        public const uint ROBOT_STATE_ATTACHED_OBJECTS = 4;
        //  The names of the world objects
        public const uint WORLD_OBJECT_NAMES = 8;
        //  The geometry of the world objects
        public const uint WORLD_OBJECT_GEOMETRY = 16;
        //  The maintained octomap
        public const uint OCTOMAP = 32;
        //  The maintained list of transforms
        public const uint TRANSFORMS = 64;
        //  The allowed collision matrix
        public const uint ALLOWED_COLLISION_MATRIX = 128;
        //  The default link padding and link scaling
        public const uint LINK_PADDING_AND_SCALING = 256;
        //  The stored object colors
        public const uint OBJECT_COLORS = 512;
        //  Bitfield combining options indicated above
        public uint components { get; set; }

        public PlanningSceneComponents()
        {
            this.components = 0;
        }

        public PlanningSceneComponents(uint components)
        {
            this.components = components;
        }
    }
}
#endif
