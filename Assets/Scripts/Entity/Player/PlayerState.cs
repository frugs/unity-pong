using UnityEngine;
using Assets.Scripts.Physics;

namespace Assets.Scripts.Entity.Player
{
    public class PlayerState : IPlayerState
    {
        // TODO: this shouldn't be hardcoded to a box collider
        private readonly BoxCollider2D Collider;
        private readonly Transform Transform;

        public PlayerState(BoxCollider2D collider, Transform transform)
        {
            Collider = collider;
            Transform = transform;
        }

        bool IPlayerState.IsAirborne()
        {
            RaycastHit2D result = UnityEngine.Physics2D.Raycast(Transform.position.XY() - (Collider.size.YOnly() * 2.05f), Direction.Down, 0.005f);
            return !result;
        }
    }
}
