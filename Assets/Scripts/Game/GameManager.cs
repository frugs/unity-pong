using UnityEngine;
using System.Text;

namespace Pong.Scripts.Game
{
    class GameManager : MonoBehaviour
    {
        public Camera mainCam;

        public Rigidbody2D Ball;

        public Transform Player1;
        public Transform Player2;

        public BoxCollider2D topWall;
        public BoxCollider2D bottomWall;
        public BoxCollider2D rightWall;
        public BoxCollider2D leftWall;

        public void Start()
        {
            //Move each wall to its edge location:
            topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
            topWall.center = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

            bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
            bottomWall.center = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

            leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y); ;
            leftWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);

            rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
            rightWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);

            //Move the players to a fixed distance from the edges of the screen:
            Player1.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x, 0f);
            Player2.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width - 75f, 0f, 0f)).x, 0f);

            Ball.velocity = new Vector2(10f, 0f);
        }
    }
}
