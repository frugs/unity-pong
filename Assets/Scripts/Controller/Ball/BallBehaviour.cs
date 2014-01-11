using UnityEngine;
using System.Collections;
using Pong.Physics.Collision;
using System;
using Pong.Unity;

namespace Pong.Controller.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallBehaviour : AbstractBehaviour<BallBehaviour>
    {
        private readonly CollidableDictionary Collidables = new CollidableDictionary();

        public override void Start()
        {
            Collidables.Add(new BallPlayerCollidable(rigidbody2D));
        }

        protected override BallBehaviour GetCollidingInstance()
        {
            return this;
        }

        public override CollidableDictionary GetCollidableDictionary()
        {
            return Collidables;
        }
    }
}
