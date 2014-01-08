using UnityEngine;

namespace Pong.Controller.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovable : MonoBehaviour
    {
        const float speed = 10f;
    
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

