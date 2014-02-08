
namespace Assets.Scripts.Entity
{
    public interface IEntityController<T> where T: IControllable
    {
        void Control(T controllable);
    }
}
