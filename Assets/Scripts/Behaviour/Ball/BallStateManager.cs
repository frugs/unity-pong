namespace Pong.Behaviour.Ball
{
    public class BallStateManager : AbstractStateManager<IBallState>
    {
        private IBallState ballIdleState;

        public BallStateManager(IBallState ballIdleState)
        {
            this.ballIdleState = ballIdleState;
            ActiveState = ballIdleState;
        }
    }
}
