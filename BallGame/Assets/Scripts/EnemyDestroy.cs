using UnityEngine;
using System.Collections;

public class EnemyDestroy : MonoBehaviour {
    [SerializeField]
    private GameObject enemy;
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            DestroyObject(enemy);
        }
    }
}
