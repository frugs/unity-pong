using UnityEngine;
using System.Collections;
using Pong.Physics.Collision;
using System;

namespace Pong.Controller.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallBehaviour : CollidingBehaviour<BallBehaviour>
    {
        protected override BallBehaviour GetCollidingInstance()
        {
            return this;
        }
    }

}
