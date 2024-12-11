/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Lifecycle
{
    public class TransitionDescription : Message
    {
        public const string RosMessageName = "lifecycle_msgs/msg/TransitionDescription";

        //  The transition id and label of this description.
        public Transition transition { get; set; }
        //  The current state from which this transition transitions.
        public State start_state { get; set; }
        //  The desired target state of this transition.
        public State goal_state { get; set; }

        public TransitionDescription()
        {
            this.transition = new Transition();
            this.start_state = new State();
            this.goal_state = new State();
        }

        public TransitionDescription(Transition transition, State start_state, State goal_state)
        {
            this.transition = transition;
            this.start_state = start_state;
            this.goal_state = goal_state;
        }
    }
}
#endif