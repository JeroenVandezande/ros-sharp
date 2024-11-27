/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.Moveit;
using RosSharp.RosBridgeClient.MessageTypes.Geometry;
using RosSharp.RosBridgeClient.MessageTypes.BuiltinInterfaces;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class PositionIKRequest : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/PositionIKRequest";

        //  A Position IK request message
        //  The name of the group which will be used to compute IK
        //  e.g. "right_arm", or "arms" - see IK specification for multiple-groups below
        //  Information from the SRDF will be used to automatically determine which link
        //  to solve IK for, unless ik_link_name is also specified
        public string group_name { get; set; }
        //  A RobotState consisting of hint/seed positions for the IK computation and positions
        //  for all the other joints in the robot. Additional state information provided here is
        //  used to specify starting positions for other joints/links on the robot.
        //  This state MUST contain state for all joints to be used by the IK solver
        //  to compute IK. The list of joints that the IK solver deals with can be
        //  found using the SRDF for the corresponding group
        public RobotState robot_state { get; set; }
        //  A set of constraints that the IK must obey; by default, this set of constraints is empty
        public Constraints constraints { get; set; }
        //  Find an IK solution that avoids collisions. By default, this is false
        public bool avoid_collisions { get; set; }
        //  (OPTIONAL) The name of the link for which we are computing IK
        //  If not specified, the link name will be inferred from a combination
        //  of the group name and the SRDF. If any values are specified for ik_link_names,
        //  this value is ignored
        public string ik_link_name { get; set; }
        //  The stamped pose of the link, when the IK solver computes the joint values
        //  for all the joints in a group. This value is ignored if pose_stamped_vector
        //  has any elements specified.
        public PoseStamped pose_stamped { get; set; }
        //  Multi-group parameters
        //  (OPTIONAL) The names of the links for which we are computing IK
        //  If not specified, the link name will be inferred from a combination
        //  of the group name and the SRDF
        public string[] ik_link_names { get; set; }
        //  (OPTIONAL) The (stamped) poses of the links we are computing IK for (when a group has more than one end effector)
        //  e.g. The "arms" group might consist of both the "right_arm" and the "left_arm"
        //  The order of the groups referred to is the same as the order setup in the SRDF
        public PoseStamped[] pose_stamped_vector { get; set; }
        //  Maximum allowed time for IK calculation
        public Duration timeout { get; set; }

        public PositionIKRequest()
        {
            this.group_name = "";
            this.robot_state = new RobotState();
            this.constraints = new Constraints();
            this.avoid_collisions = false;
            this.ik_link_name = "";
            this.pose_stamped = new PoseStamped();
            this.ik_link_names = new string[0];
            this.pose_stamped_vector = new PoseStamped[0];
            this.timeout = new Duration();
        }

        public PositionIKRequest(string group_name, RobotState robot_state, Constraints constraints, bool avoid_collisions, string ik_link_name, PoseStamped pose_stamped, string[] ik_link_names, PoseStamped[] pose_stamped_vector, Duration timeout)
        {
            this.group_name = group_name;
            this.robot_state = robot_state;
            this.constraints = constraints;
            this.avoid_collisions = avoid_collisions;
            this.ik_link_name = ik_link_name;
            this.pose_stamped = pose_stamped;
            this.ik_link_names = ik_link_names;
            this.pose_stamped_vector = pose_stamped_vector;
            this.timeout = timeout;
        }
    }
}
#endif
