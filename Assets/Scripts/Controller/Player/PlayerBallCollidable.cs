using UnityEngine;
using Pong.Physics.Collision;
using Pong.Controller.Ball;

namespace Pong.Controller.Player
{
    class PlayerBallCollidable : AbstractCollidable<BallBehaviour>
    {
        public void StartCollision(BallBehaviour collidingBehaviour)
        {
            Debug.Log("Started Collision");
        }

        public void UpdateCollision(BallBehaviour collidingBehaviour)
        {
            Debug.Log("persisting collision");
        }

        public void EndCollision(BallBehaviour collidingBehaviour)
        {
            Debug.Log("finished collison");
        }
    }
}
