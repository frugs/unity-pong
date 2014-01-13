using UnityEngine;
using Pong.Physics.Collision;
using Pong.Behaviour.Ball;

namespace Pong.Behaviour.Player
{
    class PlayerBallCollisionHandler : AbstractCollisionHandler<BallBehaviour>
    {
        public override void StartCollision(BallBehaviour collidingBehaviour)
        {
            Debug.Log("Started Collision");
        }

        public override void UpdateCollision(BallBehaviour collidingBehaviour)
        {
            Debug.Log("persisting collision");
        }

        public override void EndCollision(BallBehaviour collidingBehaviour)
        {
            Debug.Log("finished collison");
        }
    }
}
