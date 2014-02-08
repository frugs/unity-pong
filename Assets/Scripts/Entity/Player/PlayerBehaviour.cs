using Assets.Scripts.Unity;
using Assets.Scripts.Physics.Collision;

namespace Assets.Scripts.Entity.Player
{
    public class PlayerBehaviour : AbstractBehaviour<IPlayerCollisionEntity>, IPlayerCollisionEntity
    {
        private Player Player;

        public override void Start()
        {
            Player = PlayerFactory.createPlayer(this);
        }

        public override void Update()
        {
            Player.Update();
        }

        public override CollisionHandlers GetActiveCollisionHandlers()
        {
            return Player.GetCollisionHandlers();
        }

        protected override IPlayerCollisionEntity GetCollidingInstance()
        {
            return this;
        }
    }
}
