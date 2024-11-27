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
using RosSharp.RosBridgeClient.MessageTypes.Geometry;
using RosSharp.RosBridgeClient.MessageTypes.Sensor;

namespace RosSharp.RosBridgeClient.MessageTypes.Control
{
    public class AdmittanceControllerState : Message
    {
        public const string RosMessageName = "control_msgs/msg/AdmittanceControllerState";

        //  Admittance parameters
        public Float64MultiArray mass { get; set; }
        //  6-vector of mass terms used in the admittance calculation
        public Float64MultiArray damping { get; set; }
        //  6-vector of damping terms used in the admittance calculation
        public Float64MultiArray stiffness { get; set; }
        //  6-vector of stiffness terms used in the admittance calculation
        //  Frame information
        public Quaternion rot_base_control { get; set; }
        //  quaternion describing the orientation of the control frame
        public TransformStamped ref_trans_base_ft { get; set; }
        //  force torque sensor transform at the reference joint configuration
        public Int8MultiArray selected_axes { get; set; }
        //  6-vector of 0/1 describing if admittance is enable in the corresponding control frame axis
        public String ft_sensor_frame { get; set; }
        //  name of the force torque frame
        //  State information
        public TransformStamped admittance_position { get; set; }
        //  calculated admittance position in cartesian space
        public TwistStamped admittance_acceleration { get; set; }
        //  calculated admittance acceleration in cartesian space
        public TwistStamped admittance_velocity { get; set; }
        //  calculated admittance velocity in cartesian space
        public WrenchStamped wrench_base { get; set; }
        //  wrench used in the admittance calculation
        public JointState joint_state { get; set; }
        //  calculated admittance offsets in joint space

        public AdmittanceControllerState()
        {
            this.mass = new Float64MultiArray();
            this.damping = new Float64MultiArray();
            this.stiffness = new Float64MultiArray();
            this.rot_base_control = new Quaternion();
            this.ref_trans_base_ft = new TransformStamped();
            this.selected_axes = new Int8MultiArray();
            this.ft_sensor_frame = new String();
            this.admittance_position = new TransformStamped();
            this.admittance_acceleration = new TwistStamped();
            this.admittance_velocity = new TwistStamped();
            this.wrench_base = new WrenchStamped();
            this.joint_state = new JointState();
        }

        public AdmittanceControllerState(Float64MultiArray mass, Float64MultiArray damping, Float64MultiArray stiffness, Quaternion rot_base_control, TransformStamped ref_trans_base_ft, Int8MultiArray selected_axes, String ft_sensor_frame, TransformStamped admittance_position, TwistStamped admittance_acceleration, TwistStamped admittance_velocity, WrenchStamped wrench_base, JointState joint_state)
        {
            this.mass = mass;
            this.damping = damping;
            this.stiffness = stiffness;
            this.rot_base_control = rot_base_control;
            this.ref_trans_base_ft = ref_trans_base_ft;
            this.selected_axes = selected_axes;
            this.ft_sensor_frame = ft_sensor_frame;
            this.admittance_position = admittance_position;
            this.admittance_acceleration = admittance_acceleration;
            this.admittance_velocity = admittance_velocity;
            this.wrench_base = wrench_base;
            this.joint_state = joint_state;
        }
    }
}
#endif
