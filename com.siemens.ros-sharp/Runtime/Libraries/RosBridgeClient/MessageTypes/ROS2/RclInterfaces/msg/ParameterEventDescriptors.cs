/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.RclInterfaces
{
    public class ParameterEventDescriptors : Message
    {
        public const string RosMessageName = "rcl_interfaces/msg/ParameterEventDescriptors";

        //  This message contains descriptors of a parameter event.
        //  It was an atomic update.
        //  A specific parameter name can only be in one of the three sets.
        public ParameterDescriptor[] new_parameters { get; set; }
        public ParameterDescriptor[] changed_parameters { get; set; }
        public ParameterDescriptor[] deleted_parameters { get; set; }

        public ParameterEventDescriptors()
        {
            this.new_parameters = new ParameterDescriptor[0];
            this.changed_parameters = new ParameterDescriptor[0];
            this.deleted_parameters = new ParameterDescriptor[0];
        }

        public ParameterEventDescriptors(ParameterDescriptor[] new_parameters, ParameterDescriptor[] changed_parameters, ParameterDescriptor[] deleted_parameters)
        {
            this.new_parameters = new_parameters;
            this.changed_parameters = changed_parameters;
            this.deleted_parameters = deleted_parameters;
        }
    }
}
#endif
