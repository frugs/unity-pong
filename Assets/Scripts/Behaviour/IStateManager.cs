using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pong.Physics.Collision;

namespace Pong.Behaviour
{
    public interface IStateManager
    {
        CollisionHandlerDictionary GetActiveCollisionHandlers();
    }
}
