using UnityEngine;
using System.Collections;

public class PlayerManagement : MonoBehaviour {

    public int Life;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //Damage(1);
        if (Life <= 0)
        {
            Destroy(gameObject, 2f);
            Debug.Log("Player has died.");
            
        }
	}
    public void Damage(int damage)
    {
        Life -= damage;
    }

}
