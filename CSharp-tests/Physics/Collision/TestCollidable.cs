using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Physics.Collision
{
    public class TestCollidable : Collidable<SomeType>
    {
        void Collidable<SomeType>.StartCollision(SomeType collidingBehaviour)
        {
            throw new NotImplementedException();
        }

        void Collidable<SomeType>.UpdateCollision(SomeType collidingBehaviour)
        {
            throw new NotImplementedException();
        }

        void Collidable<SomeType>.EndCollision(SomeType collidingBehaviour)
        {
            throw new NotImplementedException();
        }
    }

    public interface SomeType { }
}
