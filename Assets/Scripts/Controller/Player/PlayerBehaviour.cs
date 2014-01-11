using System;
using System.Collections.Generic;
using UnityEngine;
using Pong;
using Pong.Physics.Collision;
using Pong.Unity;
using Pong.Controller.Ball;

namespace Pong.Controller.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerBehaviour : AbstractBehaviour<Entity.Player>, Entity.Player
    {
        private PlayerMovable Movable;
        private PlayerInputMovementController MovementController;

        private CollidableDictionary Collidables = new CollidableDictionary();


        public override void Start()
        {
            Movable = new PlayerMovable(rigidbody2D);
            MovementController = new PlayerInputMovementController(Movable);
            Collidables.Add(new PlayerBallCollidable());
            
            MovementController.RegisterInputs();
        }

        public override CollidableDictionary GetCollidableDictionary()
        {
            return Collidables;
        }

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
