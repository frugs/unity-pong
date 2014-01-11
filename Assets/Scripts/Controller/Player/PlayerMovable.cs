using UnityEngine;

namespace Pong.Controller.Player
{
    public class PlayerMovable
    {
        const float speed = 10f;

        private readonly Rigidbody2D rigidbody2D;

        public PlayerMovable(Rigidbody2D rigidbody2D)
        {
            this.rigidbody2D = rigidbody2D;
        }
    
        public void MoveUp()
        {
            rigidbody2D.velocity = new Vector2(0, speed);
        }
    
        public void MoveDown()
        {
            rigidbody2D.velocity = new Vector2(0, -speed);
        }
    
        public void Stop()
        {
            rigidbody2D.velocity = Vector2.zero;
        }
    }
}

