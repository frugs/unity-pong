using Pong.Physics.Collision;

namespace Pong.Behaviour.Ball
{
    public class BallIdleState : IBallState
    {
        private CollisionHandlerDictionary CollisionHandlers = new CollisionHandlerDictionary();

        CollisionHandlerDictionary IState.GetCollisionHandlers()
        {
            return CollisionHandlers;
        }

        void IState.OnEnable()
        {
        }

        void IState.OnDisable()
        {
        }
    }
}
