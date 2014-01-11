namespace Pong.Physics.Collision
{
    public interface Collidable<T>
    {
        void StartCollision(T collidingBehaviour);

        void UpdateCollision(T collidingBehaviour);

        void EndCollision(T collidingBehaviour);
    }
}

