using UnityEngine;
using Pong.Input;

namespace Pong.Behaviour.Player
{
    public class PlayerInputMovementController
    {
        private readonly PlayerMovable Movable;
        private MovementType ActiveMovementType; 

        public PlayerInputMovementController(PlayerMovable movable)
        {
            Movable = movable;
        }
    
        public void RegisterInputs()
        {
            var inputHandlers = InputHandlers.GetInputHandlers();
    
            inputHandlers.InputHandlerFor(GetMoveUpKey()).RegisterAction(
                () => {
                    Movable.MoveUp();
                    ActiveMovementType = MovementType.MovingUp;
                },
                () => {
                    if (ActiveMovementType == MovementType.MovingUp)
                    {
                        Movable.Stop();
                        ActiveMovementType = MovementType.Stopped;
                    }
                }
            );
    
            inputHandlers.InputHandlerFor(GetMoveDownKey()).RegisterAction(
                () => {
                    Movable.MoveDown();
                    ActiveMovementType = MovementType.MovingDown;
                },
                () => {
                    if (ActiveMovementType == MovementType.MovingDown)
                    {
                        Movable.Stop();
                        ActiveMovementType = MovementType.Stopped;
                    }
                }
            );
        }

        // Grab it from a static call to Config.Player.InputConfig or something, hardcoding it for now
        private KeyCode GetMoveDownKey()
        {
            return KeyCode.S;
        }

        // Grab it from a static call to Config.Player.InputConfig or something, hardcoding it for now
        private KeyCode GetMoveUpKey()
        {
            return KeyCode.W;
        }

        private enum MovementType
        {
            MovingUp,
            MovingDown,
            Stopped
        }
    }
}