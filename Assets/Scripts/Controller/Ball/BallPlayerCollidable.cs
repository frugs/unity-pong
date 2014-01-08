using System.Text;
using UnityEngine;
using Pong.Physics.Collision;
using Pong.Entity;

namespace Pong.Controller.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    class BallPlayerCollidable : Collidable<Entity.Player>
    {
        public override void EndCollision(Entity.Player collidingBehaviour)
        {
            rigidbody2D.velocity = rigidbody2D.velocity + collidingBehaviour.GetVelocity();
        }
    }
}