/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.RmwDdsCommon
{
    public class ParticipantEntitiesInfo : Message
    {
        public const string RosMessageName = "rmw_dds_common/msg/ParticipantEntitiesInfo";

        public Gid gid { get; set; }
        public NodeEntitiesInfo[] node_entities_info_seq { get; set; }

        public ParticipantEntitiesInfo()
        {
            this.gid = new Gid();
            this.node_entities_info_seq = new NodeEntitiesInfo[0];
        }

        public ParticipantEntitiesInfo(Gid gid, NodeEntitiesInfo[] node_entities_info_seq)
        {
            this.gid = gid;
            this.node_entities_info_seq = node_entities_info_seq;
        }
    }
}
#endif
