using UnityEngine;

namespace Woolholm.UnityUtils
{
    /// <summary>
    /// SceneSingleton class that can be used to create a singleton of a component.
    /// The singleton instance will not persist across scene loads.
    /// </summary>
    /// <typeparam name="T">The type of component to be used as a singleton.</typeparam>
    public class SceneSingleton<T> : Singleton<T> where T : Component
    {
        protected override void Awake()
        {
            if (instance == null)
            {
                instance = this as T;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}