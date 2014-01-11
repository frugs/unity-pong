using UnityEngine;
using System.Collections.Generic;
using Pong.Physics.Collision;

namespace Pong.Unity
{
    public abstract class AbstractBehaviour<T> : GenericAbstractBehaviour
    {
        virtual public void Start() { }
        virtual public void Update() { }

        abstract protected T GetCollidingInstance();

        public void OnCollisionEnter2D(Collision2D collision)
        {
            IEnumerable<Collidable<T>> collidables = extractCollidables(collision);

            foreach (Collidable<T> collidable in collidables)
            {
                collidable.StartCollision(GetCollidingInstance());
            }
        }

        public void OnCollisionStay2D(Collision2D collision)
        {
            IEnumerable<Collidable<T>> collidables = extractCollidables(collision);


            foreach (Collidable<T> collidable in collidables)
            {
                collidable.UpdateCollision(GetCollidingInstance());
            }
        }

        public void OnCollisionExit2D(Collision2D collision)
        {
            IEnumerable<Collidable<T>> collidables = extractCollidables(collision);

            foreach (Collidable<T> collidable in collidables)
            {
                collidable.EndCollision(GetCollidingInstance());
            }
        }

        public override CollidableDictionary GetCollidableDictionary()
        {
            return new CollidableDictionary();
        }
        
        private IEnumerable<Collidable<T>> extractCollidables(Collision2D collision)
        {
            GenericAbstractBehaviour genericAbstractBehaviour = collision.gameObject.GetComponent<GenericAbstractBehaviour>();
            return genericAbstractBehaviour != null
                ? genericAbstractBehaviour.GetCollidableDictionary().GetCollisionHandlers<T>()
                : new List<Collidable<T>>();
        }
    }

    public abstract class GenericAbstractBehaviour : MonoBehaviour
    {
        abstract public CollidableDictionary GetCollidableDictionary();
    }
}
