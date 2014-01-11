using UnityEngine;
using Pong.Input;

namespace Pong.Controller.Player
{
    public class PlayerInputMovementController
    {
        private readonly PlayerMovable Movable;

        public PlayerInputMovementController(PlayerMovable movable)
        {
            Movable = movable;
        }
    
        public void RegisterInputs()
        {
            var inputHandlers = InputHandlers.GetInputHandlers();
    
            inputHandlers.InputHandlerFor(GetMoveUpKey()).RegisterAction(
                () => {
                Movable.MoveUp(); },
                () => {
                Movable.Stop(); }
            );
    
            inputHandlers.InputHandlerFor(GetMoveDownKey()).RegisterAction(
                () => {
                Movable.MoveDown(); },
                () => {
                Movable.Stop(); }
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
    }
}