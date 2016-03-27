using UnityEngine;
using System.Collections;

public class CoinDestroy : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GameManager.Instance.CoinCount++;
            DestroyObject(gameObject);
        }
    }
}
