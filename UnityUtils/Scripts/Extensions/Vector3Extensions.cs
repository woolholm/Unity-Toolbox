using UnityEngine;

namespace Woolholm.UnityUtils
{
    public static class Vector3Extensions
    {
        /// <summary>
        /// Adds to any x, y, z value of a Vector3.
        /// </summary>
        public static Vector3 Add(this Vector3 vector, float x = 0, float y = 0, float z = 0)
        {
            return new Vector3(vector.x + x, vector.y + y, vector.z + z);
        }

        /// <summary>
        /// Sets the x, y, z value of a Vector3.
        /// </summary>
        public static Vector3 Set(this Vector3 vector, float? x = null, float? y = null, float? z = null)
        {
            return new Vector3(x ?? vector.x, y ?? vector.y, z ?? vector.z);
        }

        /// <summary>
        /// Creates a Vector2 from a Vector3.
        /// </summary>
        /// <returns>A Vector3 with the x and z values of the Vector2 with a y value of 0</returns>
        public static Vector3 toVector3(this Vector2 vector)
        {
            return new Vector3(vector.x, 0, vector.y);
        }
    }
}