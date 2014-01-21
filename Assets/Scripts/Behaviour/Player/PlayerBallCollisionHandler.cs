using UnityEngine;
using Pong.Physics.Collision;
using Pong.Entity;

namespace Pong.Behaviour.Player
{
    class PlayerBallCollisionHandler : AbstractCollisionHandler<IBall>
    {
        public override void StartCollision(IBall collidingBehaviour)
        {
            Debug.Log("Started Collision");
        }

        public override void UpdateCollision(IBall collidingBehaviour)
        {
            Debug.Log("persisting collision");
        }

        public override void EndCollision(IBall collidingBehaviour)
        {
            Debug.Log("finished collison");
        }
    }
}
