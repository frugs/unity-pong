using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pong.Physics.Collision;
using System.Collections.Generic;

namespace Pong.Physics.Collision
{
    [TestClass]
    public class CollidableDictionaryTest
    {
        private CollidableDictionary Collidables;

        [TestInitialize]
        public void SetUp()
        {
            Collidables = new CollidableDictionary();
        }

        [TestMethod]
        public void get_collision_handlers_for_a_particular_type()
        {
            Collidable<SomeType> expectedCollidable = new TestCollidable();
            Collidables.Add(expectedCollidable);

            IEnumerable<Collidable<SomeType>> result = Collidables.GetCollisionHandlers<SomeType>();
            
            //TODO: Assert that the enumerable contains the expected collidable
            Assert.Inconclusive();
        }
    }
}
