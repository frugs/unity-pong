using Pong.Behaviour;
using Pong.Behaviour.Player;
using Pong.Physics.Collision;

namespace Pong.Behaviour.Player
{
    public class PlayerStateManager : AbstractStateManager<IPlayerState>
    {
        private IPlayerState IdleState;

        public PlayerStateManager(IPlayerState idleState)
        {
            IdleState = idleState;
            ActiveState = idleState;
        }
    }
}
