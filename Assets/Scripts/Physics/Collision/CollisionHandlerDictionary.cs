using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Pong.Physics.Collision
{
    // This class is a bit awful, I cannot for the life of me figure out how to make it more concise in C#
    // Would be nice if we could have compiler-checked type safety on this as well, at the moment it relies
    // on the implemenation of the logic being type-safe.
    //
    // TODO: This class would benefit greatly from unit tests
    public class CollisionHandlerDictionary
    {
        private readonly Dictionary<Type, List<object>> UntypedCollisionHandlerDictionary = new Dictionary<Type, List<object>>();

        public IEnumerable<ICollisionHandler<T>> ForType<T>()
        {
            List<object> collisionHandlers;

            if (!UntypedCollisionHandlerDictionary.TryGetValue(typeof(T), out collisionHandlers))
            {
                collisionHandlers = new List<object>();
            }
            return new CollisionHandlerEnumerable<T>(collisionHandlers);
        }

        public void Add<T>(ICollisionHandler<T> collisionHandler)
        {
            List<object> collisionHandlers;

            if (!UntypedCollisionHandlerDictionary.TryGetValue(typeof(T), out collisionHandlers))
            {
                collisionHandlers = new List<object>();
                UntypedCollisionHandlerDictionary.Add(typeof(T), collisionHandlers);
            }
            collisionHandlers.Add(collisionHandler);
        }

        private class CollisionHandlerEnumerable<C> : IEnumerable<ICollisionHandler<C>>
        {
            private readonly IEnumerable<object> Enumerable;

            public CollisionHandlerEnumerable(IEnumerable<object> enumerable)
            {
                Enumerable = enumerable;
            }

            public IEnumerator<ICollisionHandler<C>> GetEnumerator()
            {
                return new CollisionHandlerEnumerator<C>(Enumerable.GetEnumerator());
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        private class CollisionHandlerEnumerator<C> : IEnumerator<ICollisionHandler<C>>
        {
            private readonly IEnumerator<object> Enumerator;

            public CollisionHandlerEnumerator(IEnumerator<object> enumerator)
            {
                Enumerator = enumerator;
            }

            public ICollisionHandler<C> Current
            {
                get { return (ICollisionHandler<C>)Enumerator.Current; }
            }

            public void Dispose()
            {
                Enumerator.Dispose();
            }

            object System.Collections.IEnumerator.Current
            {
                get { return Enumerator.Current; }
            }

            public bool MoveNext()
            {
                return Enumerator.MoveNext();
            }

            public void Reset()
            {
                Enumerator.Reset();
            }
        }
    }
}
