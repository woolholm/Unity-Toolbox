using UnityEngine;

namespace Woolholm.UnityUtils
{
    /// <summary>
    /// Singleton class that can be used to create a singleton of a component.
    /// The singleton instance will persist across scene loads.
    /// </summary>
    /// <typeparam name="T">The type of component to be used as a singleton.</typeparam>
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        protected static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindAnyObjectByType<T>();
                    if (instance == null)
                    {
                        GameObject obj = new GameObject();
                        instance = obj.AddComponent<T>();
                        obj.name = typeof(T).Name;
                    }
                }
                return instance;
            }
        }

        protected virtual void Awake()
        {
            if (instance == null)
            {
                instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}