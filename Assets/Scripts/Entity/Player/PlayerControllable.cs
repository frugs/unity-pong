using Assets.Scripts.Physics;
using UnityEngine;

namespace Assets.Scripts.Entity.Player
{
    public class PlayerControllable : IPlayerControllable
    {
        private static readonly float JumpSpeed = 7.5f;
        private static readonly float WalkSpeed = 3f;
        private static readonly float DriftCoefficient = 0.08f;

        private readonly Rigidbody2D Rigidbody2D;

        private bool controllable = true;

        public PlayerControllable(Rigidbody2D rigidbody2D)
        {
            Rigidbody2D = rigidbody2D;
        }

        bool IControllable.IsControllable()
        {
            return controllable;
        }

        void IPlayerControllable.Jump()
        {
            Rigidbody2D.velocity = Rigidbody2D.velocity.XOnly() + (JumpSpeed * Direction.Up);
        }

        void IPlayerControllable.Stop()
        {
            Rigidbody2D.velocity = Rigidbody2D.velocity.YOnly();
        }

        void IPlayerControllable.WalkLeft()
        {
            Rigidbody2D.velocity = WalkSpeed * Direction.Left + Rigidbody2D.velocity.YOnly();
        }

        void IPlayerControllable.WalkRight()
        {
            Rigidbody2D.velocity = WalkSpeed * Direction.Right + Rigidbody2D.velocity.YOnly();
        }

        void IPlayerControllable.AirborneDriftLeft()
        {
            Rigidbody2D.velocity = Rigidbody2D.velocity + (WalkSpeed * DriftCoefficient * Direction.Left); 
            
            if (Rigidbody2D.velocity.LeftOf(WalkSpeed * Direction.Left))
            {
                Rigidbody2D.velocity = Rigidbody2D.velocity.YOnly() + (WalkSpeed * Direction.Left);
            }
        }

        void IPlayerControllable.AirborneDriftRight()
        {
            Rigidbody2D.velocity = Rigidbody2D.velocity + (WalkSpeed * DriftCoefficient * Direction.Right); 
            
            if (Rigidbody2D.velocity.RightOf(WalkSpeed * Direction.Right))
            {
                Rigidbody2D.velocity = Rigidbody2D.velocity.YOnly() + (WalkSpeed * Direction.Right);
            }
        }
    }
}
