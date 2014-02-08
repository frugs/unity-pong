namespace Assets.Scripts.Entity.Player
{
    public class InputPlayerController : AbstractPlayerController
    {
        protected override IEntityController<IPlayerControllable> AirbornePlayerController { get; set; }
        protected override IEntityController<IPlayerControllable> GroundedPlayerController { get; set;  }

        public InputPlayerController(IPlayerState playerState) : base(playerState)
        {
            AirbornePlayerController = new InputAirbornePlayerController();
            GroundedPlayerController = new InputGroundedPlayerController();
        }

        private class InputAirbornePlayerController : AbstractEntityController<IPlayerControllable>
        {
            protected override void DoControl(IPlayerControllable controllable)
            {
                if (PlayerInput.LeftIsPressed())
                {
                    controllable.AirborneDriftLeft();
                }

                if (PlayerInput.RightIsPressed())
                {
                    controllable.AirborneDriftRight();
                }
            }
        }

        public class InputGroundedPlayerController : AbstractEntityController<IPlayerControllable>
        {
            protected override void DoControl(IPlayerControllable controllable)
            {
                if (PlayerInput.LeftIsPressed())
                {
                    controllable.WalkLeft();
                }

                if (PlayerInput.RightIsPressed())
                {
                    controllable.WalkRight();
                }

                if (PlayerInput.JumpIsPressed())
                {
                    controllable.Jump();
                }

                if (PlayerInput.NoDirectionsPressed())
                {
                    controllable.Stop();
                }
            }
        }
    }
}
