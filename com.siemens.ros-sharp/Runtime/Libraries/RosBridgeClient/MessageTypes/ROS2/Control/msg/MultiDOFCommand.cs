/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Control
{
    public class MultiDOFCommand : Message
    {
        public const string RosMessageName = "control_msgs/msg/MultiDOFCommand";

        //  The message defines command for multiple degrees of freedom (DoF) typically used by many controllers.
        //  The message intentionally avoids 'joint' nomenclature because it can be generally use for command with
        //  different semantic meanings, e.g., joints, Cartesian axes, or have abstract meaning like GPIO interface.
        //  names of degrees of freedom
        public string[] dof_names { get; set; }
        //  values used by most of the controller
        public double[] values { get; set; }
        //  First derivation of the values, e.g., velocity if values are positions.
        //  This is useful for PID and similar controllers.
        public double[] values_dot { get; set; }

        public MultiDOFCommand()
        {
            this.dof_names = new string[0];
            this.values = new double[0];
            this.values_dot = new double[0];
        }

        public MultiDOFCommand(string[] dof_names, double[] values, double[] values_dot)
        {
            this.dof_names = dof_names;
            this.values = values;
            this.values_dot = values_dot;
        }
    }
}
#endif
