﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameObjectUtil
{
    private static Dictionary<RecycleGameObject, ObjectPool> pools = new Dictionary<RecycleGameObject, ObjectPool>();

    public static GameObject Instantiate(GameObject prefab, Vector3 pos)
    {
        GameObject _instance = null;

        var recycleScript = prefab.GetComponent<RecycleGameObject>();
        if (recycleScript != null)
        {
            var pool = GetObjectPool(recycleScript);
            _instance = pool.NextObject(pos).gameObject;
        }
        else
        {
            _instance = GameObject.Instantiate(prefab);
            _instance.transform.position = pos;
        }
        return _instance;
    }

    public static void Destroy(GameObject gameObject)
    {
        var recycleGameObject = gameObject.GetComponent<RecycleGameObject>();
        if (recycleGameObject == null)
            GameObject.Destroy(gameObject);
        else
            recycleGameObject.Shutdown();
    }

    private static ObjectPool GetObjectPool(RecycleGameObject reference)
    {
        ObjectPool pool = null;

        if (pools.ContainsKey(reference))
        {
            pool = pools[reference];
        }
        else
        {
            var poolContainer = new GameObject(reference.gameObject.name + "ObjectPool");
            pool = poolContainer.AddComponent<ObjectPool>();
            pool.prefab = reference;
            pools.Add(reference, pool);
        }

        return pool;
    }

}