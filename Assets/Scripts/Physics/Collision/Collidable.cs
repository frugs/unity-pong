using UnityEngine;

namespace Pong.Physics.Collision
{
    public abstract class Collidable<T> : MonoBehaviour
    {
        public virtual void StartCollision(T collidingBehaviour)
        {
        }

        public virtual void UpdateCollision(T collidingBehaviour)
        {
        }

        public virtual void EndCollision(T collidingBehaviour)
        { 
        }
    }
}

