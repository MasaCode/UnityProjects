using UnityEngine;
using System.Collections;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour {

    private static T instanceSomething;

    public static T Instance
    {
        get
        {
            if (instanceSomething == null)
            {
                instanceSomething = GameObject.FindObjectOfType<T>(); // try to find the GameObjects.
                if (instanceSomething == null)
                {
                    GameObject singleton = new GameObject(typeof(T).Name);
                    instanceSomething = singleton.AddComponent<T>(); // Creating a GameObject from nothing.
                }
            }
            return instanceSomething;
        }
    }


    public virtual void Awake() // It's virtual function because I need to create GameManager class extends this class. So it must be virtual.
    {
        if (instanceSomething == null)
        {
            instanceSomething = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);// if the GameObjects are created already, just destroy them.
        }
    }

}
