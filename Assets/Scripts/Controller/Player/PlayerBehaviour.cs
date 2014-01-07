using Pong.Physics.Movement;
using System;
using UnityEngine;
using Pong.Physics.Collision;

namespace Pong.Controller.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerBehaviour : CollidingBehaviour<PlayerBehaviour>
    {
        public KeyCode MoveUpKey;
        public KeyCode MoveDownKey;
    
        private Movable Movable;
        private MovementController MovementController;
    
        // Would be nice if we could extract the following into a separate class; the Player class itself
        // needn't know what it's composed of.
        void Start()
        {
            Movable = new PlayerMovable(rigidbody2D);
            MovementController = new PlayerInputMovementController(MoveUpKey, MoveDownKey);
    
            MovementController.ControlMovement(Movable);
        }

        protected override PlayerBehaviour GetCollidingInstance()
        {
            return this;
        }
    }
}
