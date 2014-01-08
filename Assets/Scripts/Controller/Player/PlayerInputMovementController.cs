using UnityEngine;
using Pong.Input;

namespace Pong.Controller.Player
{
    [RequireComponent(typeof(PlayerMovable))]
    public class PlayerInputMovementController : MonoBehaviour
    {
        public KeyCode MoveUpKey;
        public KeyCode MoveDownKey;

        public PlayerMovable movable;
    
        public void Start()
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