using System;
using UnityEngine;

namespace Assets.Scripts.Entity.Player
{
    public static class PlayerFactory
    {
        public static Player createPlayer(MonoBehaviour behaviour)
        {
            BoxCollider2D collider2D = behaviour.collider2D as BoxCollider2D;
            if (collider2D == null)
            {
                throw new InvalidOperationException("Player requires a box collider.");
            }

            Transform transform = behaviour.transform;
            if (transform == null)
            {
                throw new InvalidOperationException("Player requires a transform.");
            }

            Rigidbody2D rigidbody2D = behaviour.rigidbody2D;
            if (rigidbody2D == null)
            {
                throw new InvalidOperationException("Player requires a rigidbody 2d.");
            }

            var playerState = new PlayerState(collider2D, transform);
            var playerControllable = new PlayerControllable(rigidbody2D);
            var playerController = new InputPlayerController(playerState);
            var playerVulnerbility = new PlayerVulnerability();

            return new Player(playerState, playerControllable, playerController, playerVulnerbility);
        }
    }
}
