using UnityEngine;
using Pong.Physics.Movement;

namespace Pong.Controller.Player
{
    public class PlayerMovable : Movable
    {
        const float speed = 10f;
    
        private Rigidbody2D PlayerRigidBody2D;
    
        public PlayerMovable(Rigidbody2D playerRigidBody2D)
        {
            this.PlayerRigidBody2D = playerRigidBody2D;
        }
        
        public void MoveUp()
        {
            PlayerRigidBody2D.velocity = new Vector2(0, speed);
        }
    
        public void MoveDown()
        {
            PlayerRigidBody2D.velocity = new Vector2(0, -speed);
        }
    
        public void Stop()
        {
            PlayerRigidBody2D.velocity = Vector2.zero;
        }
    }
}

