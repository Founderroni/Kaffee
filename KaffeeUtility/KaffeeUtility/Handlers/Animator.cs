using Transitions;

namespace KaffeeUtility.Handlers
{
    internal class Animator
    {
        public static void Linear(object target, string propertyName, object destinationValue, int msTime) =>
            Transition.run(target, propertyName, destinationValue, new TransitionType_Linear(msTime));
    }
}
