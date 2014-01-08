using System;
using UnityEngine;
using Pong.Physics.Collision;

namespace Pong.Controller.Player
{
    [RequireComponent(typeof(PlayerMovable), typeof(PlayerInputMovementController))]
    public class PlayerBehaviour : CollidingBehaviour<PlayerBehaviour>
    {
        public PlayerMovable Movable;
        public PlayerInputMovementController MovementController;

        protected override PlayerBehaviour GetCollidingInstance()
        {
            return this;
        }
    }
}
