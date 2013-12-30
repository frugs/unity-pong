using UnityEngine;
using System;
using System.Collections;
using Pong.Physics.Movement;

namespace Pong.Controller.Player
{
    public class Player : MonoBehaviour
    {
    
        public KeyCode MoveUpKey;
        public KeyCode MoveDownKey;
    
        private Movable Movable;
        private MovementController MovementController;
    
        // Would be nice if we could extract the following into a separate class; the Player class itself
        // needn't know what it's composed of.
        void Start()
        {
            if (rigidbody2D == null) {
                throw new InvalidOperationException("Player has no rigid body attached");
            }
    
            Movable = new PlayerMovable(rigidbody2D);
            MovementController = new PlayerInputMovementController(MoveUpKey, MoveDownKey);
    
            MovementController.ControlMovement(Movable);
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }
}
