using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Entity
{
    public abstract class AbstractEntityController<T> : IEntityController<T> where T : IControllable
    {
        void IEntityController<T>.Control(T controllable)
        {
            if (controllable.IsControllable())
            {
                DoControl(controllable);
            }
        }

        protected abstract void DoControl(T controllable);
    }
}
