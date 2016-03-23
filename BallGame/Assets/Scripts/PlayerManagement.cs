using UnityEngine;
using System.Collections;

public class PlayerManagement : MonoBehaviour {

    public int Life;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Life <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void DamageToPlayer(int damage)
    {
        Life -= damage;
    }
}
