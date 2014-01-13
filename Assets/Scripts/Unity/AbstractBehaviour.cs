using UnityEngine;
using System.Collections.Generic;
using Pong.Entity;
using Pong.Physics.Collision;
using Pong.Behaviour;

namespace Pong.Unity
{
    public abstract class AbstractBehaviour<T> : GenericAbstractBehaviour
    {
        virtual public void Start() { }
        virtual public void Update() { }

        abstract protected T GetCollidingInstance();

        public void OnCollisionEnter2D(Collision2D collision)
        {
            IEnumerable<ICollisionHandler<T>> collidables = extractCollidables(collision);

            foreach (ICollisionHandler<T> collidable in collidables)
            {
                collidable.StartCollision(GetCollidingInstance());
            }
        }

        public void OnCollisionStay2D(Collision2D collision)
        {
            IEnumerable<ICollisionHandler<T>> collidables = extractCollidables(collision);


            foreach (ICollisionHandler<T> collidable in collidables)
            {
                collidable.UpdateCollision(GetCollidingInstance());
            }
        }

        public void OnCollisionExit2D(Collision2D collision)
        {
            IEnumerable<ICollisionHandler<T>> collidables = extractCollidables(collision);

            foreach (ICollisionHandler<T> collidable in collidables)
            {
                collidable.EndCollision(GetCollidingInstance());
            }
        }

        private IEnumerable<ICollisionHandler<T>> extractCollidables(Collision2D collision)
        {
            GenericAbstractBehaviour genericAbstractBehaviour = collision.gameObject.GetComponent<GenericAbstractBehaviour>();
            return genericAbstractBehaviour != null
                ? genericAbstractBehaviour.GetStateManager().GetActiveCollisionHandlers().ForType<T>()
                : new List<ICollisionHandler<T>>();
        }
    }

    public abstract class GenericAbstractBehaviour : MonoBehaviour
    {
        abstract public IStateManager GetStateManager();
    }
}
