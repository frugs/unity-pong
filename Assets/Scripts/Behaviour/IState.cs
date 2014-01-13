using Pong.Physics.Collision;

namespace Pong.Behaviour
{
    public interface IState
    {
        CollisionHandlerDictionary GetCollisionHandlers();

        void OnEnable();
        void OnDisable();
    }
}
