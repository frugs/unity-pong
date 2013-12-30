using UnityEngine;
using Pong.Input;
using Pong.Physics.Movement;

namespace Pong.Controller.Player
{
    public class PlayerInputMovementController : MovementController
    {
        private KeyCode MoveUpKey;
        private KeyCode MoveDownKey;
    
        public PlayerInputMovementController(KeyCode moveUpKey, KeyCode moveDownKey)
        {
            this.MoveUpKey = moveUpKey;
            this.MoveDownKey = moveDownKey;
        }
    
        public void ControlMovement(Movable movable)
        {
            var inputHandlers = InputHandlers.GetInputHandlers();
    
            inputHandlers.InputHandlerFor(MoveUpKey).RegisterAction(
                () => {
                movable.MoveUp(); },
                () => {
                movable.Stop(); }
            );
    
            inputHandlers.InputHandlerFor(MoveDownKey).RegisterAction(
                () => {
                movable.MoveDown(); },
                () => {
                movable.Stop(); }
            );
        }
    }
}