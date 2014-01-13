using Pong.Physics.Collision;

namespace Pong.Behaviour.Player
{
    public class PlayerIdleState : IPlayerState
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
