using UnityEngine;

namespace Assets.Scripts.Entity.Player
{
    public class PlayerInput
    {
        public static bool LeftIsPressed()
        {
            return Input.GetKeyDown(KeyCode.LeftArrow)
                || (!Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow));
        }

        public static bool RightIsPressed()
        {
            return Input.GetKeyDown(KeyCode.RightArrow)
                || (!Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow));
        }

        public static bool NoDirectionsPressed()
        {
            return !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow);
        }

        public static bool JumpIsPressed()
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }
}
