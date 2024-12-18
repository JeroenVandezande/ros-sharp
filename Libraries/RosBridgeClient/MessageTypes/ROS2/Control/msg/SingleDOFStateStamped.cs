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

namespace RosSharp.RosBridgeClient.MessageTypes.Control
{
    public class SingleDOFStateStamped : Message
    {
        public const string RosMessageName = "control_msgs/msg/SingleDOFStateStamped";

        //  This message presents current controller state of one degree of freedom.
        //  Header timestamp should be update time of controller state
        public Header header { get; set; }
        public SingleDOFState dof_state { get; set; }

        public SingleDOFStateStamped()
        {
            this.header = new Header();
            this.dof_state = new SingleDOFState();
        }

        public SingleDOFStateStamped(Header header, SingleDOFState dof_state)
        {
            this.header = header;
            this.dof_state = dof_state;
        }
    }
}
#endif
