/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.TypeDescriptionInterfaces
{
    public class TypeDescription : Message
    {
        public const string RosMessageName = "type_description_interfaces/msg/TypeDescription";

        //  Represents a complete type description, including the type itself as well as the types it references.
        //  Description of the type.
        public IndividualTypeDescription type_description { get; set; }
        //  Descriptions of all referenced types, recursively.
        public IndividualTypeDescription[] referenced_type_descriptions { get; set; }

        public TypeDescription()
        {
            this.type_description = new IndividualTypeDescription();
            this.referenced_type_descriptions = new IndividualTypeDescription[0];
        }

        public TypeDescription(IndividualTypeDescription type_description, IndividualTypeDescription[] referenced_type_descriptions)
        {
            this.type_description = type_description;
            this.referenced_type_descriptions = referenced_type_descriptions;
        }
    }
}
#endif