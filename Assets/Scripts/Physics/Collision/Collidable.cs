using UnityEngine;

namespace Pong.Physics.Collision
{
    public abstract class Collidable<T> : MonoBehaviour
    {
        public abstract void StartCollision(T collidingBehaviour);
        public abstract void UpdateCollision(T collidingBehaviour);
        public abstract void EndCollision(T collidingBehaviour);
    }
}

