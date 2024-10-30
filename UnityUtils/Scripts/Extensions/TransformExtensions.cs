using UnityEngine;

namespace Woolholm.UnityUtils
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Destroys all children of a transform.
        /// </summary>
        public static void DestroyChildren(this Transform parent)
        {
            parent.ForEachChildReverse(child => Object.Destroy(child.gameObject));
        }

        /// <summary>
        /// Resets the local position, rotation, and scale of a transform.
        /// </summary>
        public static void ResetLocalTransform(this Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// Resets the position, rotation, and scale of a transform.
        /// </summary>
        public static void ResetTransform(this Transform transform)
        {
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// Goes through all children of a transform and performs an action on them.
        /// See <see cref="ForEachChildReverse"/> for the reverse iteration version.
        /// </summary>
        /// <param name="parent">The parent transform</param>
        /// <param name="action">The action to be performed on each child.</param>
        /// <remarks>Useful for when the order of operations matters and you want to process children from the first to the last.</remarks>
        public static void ForEachChild(this Transform parent, System.Action<Transform> action)
        {
            for (int i = 0; i < parent.childCount; i++)
            {
                action(parent.GetChild(i));
            }
        }

        /// <summary>
        /// Goes through all children of a transform in reverse order and performs an action on them.
        /// See <see cref="ForEachChild"/> for the forward iteration version.
        /// </summary>
        /// <param name="parent">The parent transform.</param>
        /// <param name="action">The action to be performed on each child.</param>
        /// <remarks>Useful for when you want to avoid issues with index shifting.</remarks>
        /// <see cref="ForEachChild"/>
        public static void ForEachChildReverse(this Transform parent, System.Action<Transform> action)
        {
            for (int i = parent.childCount - 1; i >= 0; i--)
            {
                action(parent.GetChild(i));
            }
        }
    }
}