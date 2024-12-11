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

namespace RosSharp.RosBridgeClient.MessageTypes.Diagnostic
{
    public class DiagnosticArray : Message
    {
        public const string RosMessageName = "diagnostic_msgs/msg/DiagnosticArray";

        //  This message is used to send diagnostic information about the state of the robot.
        public Header header { get; set; }
        //  for timestamp
        public DiagnosticStatus[] status { get; set; }
        //  an array of components being reported on

        public DiagnosticArray()
        {
            this.header = new Header();
            this.status = new DiagnosticStatus[0];
        }

        public DiagnosticArray(Header header, DiagnosticStatus[] status)
        {
            this.header = header;
            this.status = status;
        }
    }
}
#endif