using System;
using UnityEngine;
using Pong;
using Pong.Physics.Collision;

namespace Pong.Controller.Player
{
    [RequireComponent(typeof(PlayerMovable), typeof(PlayerInputMovementController), typeof(Rigidbody2D))]
    public class PlayerBehaviour : CollidingBehaviour<Entity.Player>, Entity.Player
    {
        public PlayerMovable Movable;
        public PlayerInputMovementController MovementController;

        protected override Entity.Player GetCollidingInstance()
        {
            return this;
        }

        public Vector2 GetVelocity()
        {
            return rigidbody2D.velocity;
        }
    }
}
