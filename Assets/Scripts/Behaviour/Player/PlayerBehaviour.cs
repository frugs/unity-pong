using System;
using System.Collections.Generic;
using UnityEngine;
using Pong.Entity;
using Pong.Physics.Collision;
using Pong.Unity;
using Pong.Behaviour.Ball;

namespace Pong.Behaviour.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerBehaviour : AbstractBehaviour<IPlayer>, IPlayer
    {
        private PlayerMovable Movable;
        private PlayerInputMovementController MovementController;

        private PlayerStateManager StateManager;

        // TODO: This is a bit messy, encapsulate this in a factory.
        // TODO: StateManager could also use a builder class
        public override void Start()
        {
            Movable = new PlayerMovable(rigidbody2D);
            MovementController = new PlayerInputMovementController(Movable);
            MovementController.RegisterInputs();

            IPlayerState idleState = new PlayerIdleState();
            StateManager = new PlayerStateManager(idleState);
            idleState.GetCollisionHandlers().Add(new PlayerBallCollisionHandler());
        }

        public override IStateManager GetStateManager()
        {
            return StateManager;
        }

        protected override IPlayer GetCollidingInstance()
        {
            return this;
        }

        public Vector2 GetVelocity()
        {
            return rigidbody2D.velocity;
        }
    }
}
