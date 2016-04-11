using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class RecycleGameObject : MonoBehaviour
{
    private List<IRecycle> recycleComponents;

    public void Awake()
    {
        var components = GetComponents<MonoBehaviour>();
        recycleComponents = new List<IRecycle>();

        foreach (var component in components)
        {
            if (component is IRecycle)
                recycleComponents.Add(component as IRecycle);
        }
    }

    public void Restart()
    {
        gameObject.SetActive(true);

        foreach (var component in recycleComponents)
        {
            component.Restart();
        }
    }

    public void Shutdown()
    {
        gameObject.SetActive(false);

        foreach (var component in recycleComponents)
        {
            component.Shutdown();
        }
    }

}

