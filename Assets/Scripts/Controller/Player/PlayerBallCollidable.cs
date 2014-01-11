using UnityEngine;
using Pong.Physics.Collision;
using Pong.Controller.Ball;

namespace Pong.Controller.Player
{
    class PlayerBallCollidable : AbstractCollidable<BallBehaviour>
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
