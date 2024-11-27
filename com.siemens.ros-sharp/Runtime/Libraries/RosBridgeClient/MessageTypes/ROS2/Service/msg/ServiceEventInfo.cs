/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.BuiltinInterfaces;

namespace RosSharp.RosBridgeClient.MessageTypes.Service
{
    public class ServiceEventInfo : Message
    {
        public const string RosMessageName = "service_msgs/msg/ServiceEventInfo";

        public const byte REQUEST_SENT = 0;
        public const byte REQUEST_RECEIVED = 1;
        public const byte RESPONSE_SENT = 2;
        public const byte RESPONSE_RECEIVED = 3;
        //  The type of event this message represents
        public byte event_type { get; set; }
        //  Timestamp for when the event occurred (sent or received time)
        public Time stamp { get; set; }
        //  Unique identifier for the client that sent the service request
        //  Note, this is only unique for the current session.
        //  The size here has to match the size of rmw_dds_common/msg/Gid,
        //  but unfortunately we cannot use that message directly due to a
        //  circular dependency.
        public byte[] client_gid { get; set; }
        //  Sequence number for the request
        //  Combined with the client ID, this creates a unique ID for the service transaction
        public long sequence_number { get; set; }

        public ServiceEventInfo()
        {
            this.event_type = 0;
            this.stamp = new Time();
            this.client_gid = new byte[16];
            this.sequence_number = 0;
        }

        public ServiceEventInfo(byte event_type, Time stamp, byte[] client_gid, long sequence_number)
        {
            this.event_type = event_type;
            this.stamp = stamp;
            this.client_gid = client_gid;
            this.sequence_number = sequence_number;
        }
    }
}
#endif
