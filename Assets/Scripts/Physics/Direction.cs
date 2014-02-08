using UnityEngine;

namespace Assets.Scripts.Physics
{
    public static class Direction
    {
        public static readonly Vector2 Up = new Vector2(0f, 1f);
        public static readonly Vector2 Down = new Vector2(0f, -1f);
        public static readonly Vector2 Right = new Vector2(1f, 0f);
        public static readonly Vector2 Left = new Vector2(-1f, 0f);

        public static bool LeftOf(this Vector2 source, Vector2 target)
        {
            return source.LeftOf(target.x);
        }        
        
        public static bool RightOf(this Vector2 source, Vector2 target)
        {
            return source.RightOf(target.x);
        }        
        
        public static bool LeftOf(this Vector2 source, float targetX)
        {
            return source.x < targetX;
        }        
        
        public static bool RightOf(this Vector2 source, float targetX)
        {
            return source.x > targetX;
        }
    }
}
