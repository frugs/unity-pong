
namespace Assets.Scripts.Entity.Player
{
    public interface IPlayerControllable : IControllable
    {
        void Jump();

        void Stop();

        void WalkLeft();

        void WalkRight();

        void AirborneDriftLeft();

        void AirborneDriftRight();
    }
}