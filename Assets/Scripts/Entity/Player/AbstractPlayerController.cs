using UnityEngine;

namespace Assets.Scripts.Entity.Player
{
    public abstract class AbstractPlayerController : AbstractEntityController<IPlayerControllable>
    {
        private readonly IPlayerState PlayerState;

        public AbstractPlayerController(IPlayerState playerState)
        {
            PlayerState = playerState;
        }

        protected override void DoControl(IPlayerControllable playerControllable)
        {
            GetActivePlayerController().Control(playerControllable);
        }

        protected abstract IEntityController<IPlayerControllable> AirbornePlayerController { get; set; }

        protected abstract IEntityController<IPlayerControllable> GroundedPlayerController { get; set; }

        private IEntityController<IPlayerControllable> GetActivePlayerController()
        {
            return PlayerState.IsAirborne() ? AirbornePlayerController : GroundedPlayerController;
        }
    }
}
