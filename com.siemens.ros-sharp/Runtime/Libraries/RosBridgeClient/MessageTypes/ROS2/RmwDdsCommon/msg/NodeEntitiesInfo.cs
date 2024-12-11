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
    public class NodeEntitiesInfo : Message
    {
        public const string RosMessageName = "rmw_dds_common/msg/NodeEntitiesInfo";

        public string node_namespace { get; set; }
        public string node_name { get; set; }
        public Gid[] reader_gid_seq { get; set; }
        public Gid[] writer_gid_seq { get; set; }

        public NodeEntitiesInfo()
        {
            this.node_namespace = "";
            this.node_name = "";
            this.reader_gid_seq = new Gid[0];
            this.writer_gid_seq = new Gid[0];
        }

        public NodeEntitiesInfo(string node_namespace, string node_name, Gid[] reader_gid_seq, Gid[] writer_gid_seq)
        {
            this.node_namespace = node_namespace;
            this.node_name = node_name;
            this.reader_gid_seq = reader_gid_seq;
            this.writer_gid_seq = writer_gid_seq;
        }
    }
}
#endif