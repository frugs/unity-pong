using Assets.Scripts.Physics.Collision;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Entity.Player
{
    public class Player
    {
        private readonly IPlayerState PlayerState;
        private readonly IPlayerControllable PlayerControllable;
        private readonly IPlayerVulnerability PlayerVulnerablility;

        private IEntityController<IPlayerControllable> Controller;

        public Player(
            IPlayerState playerState,
            IPlayerControllable playerControllable,
            IEntityController<IPlayerControllable> controller,
            IPlayerVulnerability playerVulnerability)
        {
            PlayerState = playerState;
            PlayerControllable = playerControllable;
            Controller = controller;
            PlayerVulnerablility = playerVulnerability;
        }

        public void Update()
        {
            Controller.Control(PlayerControllable);
        }

        public CollisionHandlers GetCollisionHandlers()
        {
            return PlayerVulnerablility.GetCollisionHandlers();
        }
    }
}
