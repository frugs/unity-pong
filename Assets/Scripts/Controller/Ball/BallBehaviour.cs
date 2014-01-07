using UnityEngine;
using System.Collections;
using Pong.Physics.Collision;
using System;

namespace Pong.Controller.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallBehaviour : CollidingBehaviour<BallBehaviour>
    {
        public void Start()
        {
            rigidbody2D.velocity = new Vector2(10, 0);
        }

        protected override BallBehaviour GetCollidingInstance()
        {
            return this;
        }
    }

}
