using System.Text;
using UnityEngine;
using Pong.Physics.Collision;
using Pong.Entity;

namespace Pong.Controller.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    class BallPlayerCollidable : AbstractCollidable<Entity.Player>
    {
        private readonly Rigidbody2D Rigidbody2D;

        public BallPlayerCollidable(Rigidbody2D rigidbody2D)
        {
            Rigidbody2D = rigidbody2D;
        }

        public void EndCollision(Entity.Player collidingBehaviour)
        {
            Rigidbody2D.velocity = Rigidbody2D.velocity + collidingBehaviour.GetVelocity();
        }
    }
}