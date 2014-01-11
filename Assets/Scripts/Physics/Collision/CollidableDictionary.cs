using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pong.Physics.Collision
{
    // This class is a bit awful, I cannot for the life of me figure out how to make it more concise in C#
    // Would be nice if we could have compiler-checked type safety on this as well, at the moment it relies
    // on the implemenation of the logic being type-safe.
    public class CollidableDictionary
    {
        private readonly Dictionary<Type, List<object>> UntypedCollidableDictionary = new Dictionary<Type, List<object>>();

        public IEnumerable<Collidable<T>> GetCollisionHandlers<T>()
        {
            return new CollidableEnumerable<T>(UntypedCollidableDictionary[typeof(T)]);
        }

        public void Add<T>(Collidable<T> collidable)
        {
            List<object> collidables;

            if (!UntypedCollidableDictionary.TryGetValue(typeof(T), out collidables))
            {
                collidables = new List<object>();
            }
            collidables.Add(collidable);
        }

        private class CollidableEnumerable<C> : IEnumerable<Collidable<C>>
        {
            private readonly IEnumerable<object> Enumerable;

            public CollidableEnumerable(IEnumerable<object> enumerable)
            {
                Enumerable = enumerable;
            }

            public IEnumerator<Collidable<C>> GetEnumerator()
            {
                return new CollidableEnumerator<C>(Enumerable.GetEnumerator());
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        private class CollidableEnumerator<C> : IEnumerator<Collidable<C>>
        {
            private readonly IEnumerator<object> Enumerator;

            public CollidableEnumerator(IEnumerator<object> enumerator)
            {
                Enumerator = enumerator;
            }

            public Collidable<C> Current
            {
                get { return (Collidable<C>)Enumerator.Current; }
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
