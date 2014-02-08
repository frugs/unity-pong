using Assets.Scripts.Physics.Collision;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Unity
{
    public abstract class AbstractBehaviour<T> : AbstractBehaviour
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
            AbstractBehaviour genericAbstractBehaviour = collision.gameObject.GetComponent<AbstractBehaviour>();
            return genericAbstractBehaviour != null
                ? genericAbstractBehaviour.GetActiveCollisionHandlers().ForType<T>()
                : new List<ICollisionHandler<T>>();
        }
    }

    public abstract class AbstractBehaviour : MonoBehaviour
    {
        abstract public CollisionHandlers GetActiveCollisionHandlers();
    }
}
