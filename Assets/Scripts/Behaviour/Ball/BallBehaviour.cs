using UnityEngine;
using System.Collections;
using Pong.Physics.Collision;
using System;
using Pong.Entity;
using Pong.Unity;
using Pong.Behaviour.Ball;

namespace Pong.Behaviour.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallBehaviour : AbstractBehaviour<IBall>, IBall
    {
        private BallStateManager StateManager;

        public override void Start()
        {
            IBallState ballIdleState = new BallIdleState();
            StateManager = new BallStateManager(ballIdleState);
            ballIdleState.GetCollisionHandlers().Add(new BallPlayerCollisionHandler(rigidbody2D));
        }

        protected override IBall GetCollidingInstance()
        {
            return this;
        }

        public override IStateManager GetStateManager()
        {
            return StateManager;
        }
    }
}
