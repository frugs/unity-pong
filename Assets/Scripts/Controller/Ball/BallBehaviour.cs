using UnityEngine;
using System.Collections;
using Pong.Physics.Collision;
using System;

namespace Pong.Controller.Ball
{
    public class BallBehaviour : CollidingBehaviour<BallBehaviour>
    {
        protected override BallBehaviour GetCollidingInstance()
        {
            return this;
        }
    }
}
