using UnityEngine;

namespace Woolholm.UnityUtils
{
    public static class Vector2Extensions
    {
        /// <summary>
        /// Adds to any x, y value of a Vector2.
        /// </summary>
        public static Vector2 Add(this Vector2 vector, float x = 0, float y = 0)
        {
            return new Vector2(vector.x + x, vector.y + y);
        }

        /// <summary>
        /// Sets the x, y value of a Vector2.
        /// </summary>
        public static Vector2 Set(this Vector2 vector, float? x = null, float? y = null)
        {
            return new Vector2(x ?? vector.x, y ?? vector.y);
        }

        /// <summary>
        /// Creates a Vector3 from a Vector2.
        /// </summary>
        /// <returns>A Vector2 with the x and z values from the Vector3 x and y.</returns>
        public static Vector2 toVector2(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.z);
        }
    }
}
