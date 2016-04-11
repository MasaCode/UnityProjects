using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


class ObjectPool : MonoBehaviour
{
    public RecycleGameObject prefab;

    private List<RecycleGameObject> poolInstances = new List<RecycleGameObject>();
    
    private RecycleGameObject Createinstance(Vector3 position)
    {
        var clone = GameObject.Instantiate(prefab);
        clone.transform.position = position;
        clone.transform.parent = transform;

        poolInstances.Add(clone);

        return clone;
    }

    public RecycleGameObject NextObject(Vector3 position)
    {
        RecycleGameObject instance = null;

        foreach (var go in poolInstances)
        {
            if (go.gameObject.activeSelf != true)
            {
                instance = go;
                instance.transform.position = position;
            }
        }

        if (instance == null)
        {
            instance = Createinstance(position);
        }

        instance.Restart();

        return instance;
    }
}

