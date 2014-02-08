using System;
using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts.Physics.Collision
{
    // Would be nice if we could have compiler-checked type safety on this as well, at the moment it relies
    // on the implemenation of the logic being type-safe.
    //
    // TODO: This class would benefit greatly from unit tests
    public class CollisionHandlers
    {
        private readonly Dictionary<Type, List<object>> UntypedCollisionHandlerDictionary = new Dictionary<Type, List<object>>();

        public IEnumerable<ICollisionHandler<T>> ForType<T>()
        {
            List<object> collisionHandlers;

            if (!UntypedCollisionHandlerDictionary.TryGetValue(typeof(T), out collisionHandlers))
            {
                collisionHandlers = new List<object>();
            }
            return CastListTo<ICollisionHandler<T>>(collisionHandlers);
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

        private static IList<T> CastListTo<T>(IList<object> untypedList)
        {
            IList<T> list = new List<T>();

            foreach (object entry in untypedList) {
                list.Add((T) entry);
            }
            return list;
        }
    }
}
