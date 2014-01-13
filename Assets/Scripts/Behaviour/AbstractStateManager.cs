using UnityEngine;
using Pong.Unity;
using Pong.Physics.Collision;

namespace Pong.Behaviour
{
    public abstract class AbstractStateManager<TState> : IStateManager where TState : IState
    {
        protected TState ActiveState;

        protected void SwitchState(TState state)
        {
            ActiveState.OnDisable();

            ActiveState = state;
            ActiveState.OnEnable();
        }

        public CollisionHandlerDictionary GetActiveCollisionHandlers()
        {
            return ActiveState.GetCollisionHandlers();
        }
    }
}
