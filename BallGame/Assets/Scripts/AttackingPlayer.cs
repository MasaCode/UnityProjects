using UnityEngine;
using System.Collections;

public class AttackingPlayer : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GameManager.Instance.Attacked(10);
        }
    }
	
}
