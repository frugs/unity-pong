using System.Text;
using UnityEngine;
using Pong.Physics.Collision;
using Pong.Entity;

namespace Pong.Behaviour.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    class BallPlayerCollisionHandler : AbstractCollisionHandler<Entity.IPlayer>
    {
        private readonly Rigidbody2D Rigidbody2D;

        public BallPlayerCollisionHandler(Rigidbody2D rigidbody2D)
        {
            Rigidbody2D = rigidbody2D;
        }

        public override void EndCollision(Entity.IPlayer collidingBehaviour)
        {
            Rigidbody2D.velocity = Rigidbody2D.velocity + collidingBehaviour.GetVelocity();
        }
    }
}