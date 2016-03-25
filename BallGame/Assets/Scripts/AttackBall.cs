using UnityEngine;
using System.Collections;

public class AttackBall : MonoBehaviour {
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GameManager.Instance.Attacked(2);
        }
    }
}
