using UnityEngine;

namespace Assets.Scripts.Physics
{
    public static class VectorUtils
    {
        public static Vector2 XY(this Vector3 vector3)
        {
            return new Vector2(vector3.x, vector3.y);
        } 

        public static Vector2 XOnly(this Vector2 vector2)
        {
            return new Vector2(vector2.x, 0f);
        }
        
        public static Vector2 YOnly(this Vector2 vector2)
        {
            return new Vector2(0f, vector2.y);
        }
    }
}
