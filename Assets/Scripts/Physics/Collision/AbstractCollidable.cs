namespace Pong.Physics.Collision
{
    class AbstractCollidable<T> : Collidable<T>
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
