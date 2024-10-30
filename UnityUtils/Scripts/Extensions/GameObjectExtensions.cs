using UnityEngine;

namespace Woolholm.UnityUtils
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Gets or adds a component to a GameObject.
        /// </summary>
        /// <typeparam name="T">The type of component.</typeparam>
        /// <param name="gameObject">The GameObject to get or add the component to.</param>
        /// <returns>The existing or newly created component.</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            T component = gameObject.GetComponent<T>();
            if (component == null)
            {
                component = gameObject.AddComponent<T>();
            }
            return component;
        }
    }
}