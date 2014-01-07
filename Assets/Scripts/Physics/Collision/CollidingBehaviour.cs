using UnityEngine;
using System.Collections;

namespace Pong.Physics.Collision
{
    public abstract class CollidingBehaviour<T> : MonoBehaviour
    {
        abstract protected T GetCollidingInstance();       

        public void OnCollisionEnter2D(Collision2D collision)
        {
            Collidable<T>[] collidables = collision.gameObject.GetComponents<Collidable<T>>();

            foreach (Collidable<T> collidable in collidables)
            {
                collidable.StartCollision(GetCollidingInstance());
            }
        }

        public void OnCollisionStay2D(Collision2D collision)
        {
            Collidable<T>[] collidables = collision.gameObject.GetComponents<Collidable<T>>();

            foreach (Collidable<T> collidable in collidables)
            {
                collidable.UpdateCollision(GetCollidingInstance());
            }
        }

        public void OnCollisionExit2D(Collision2D collision)
        {
            Collidable<T>[] collidables = collision.gameObject.GetComponents<Collidable<T>>();

            foreach (Collidable<T> collidable in collidables)
            {
                collidable.EndCollision(GetCollidingInstance());
            }
        }
    } 
}

