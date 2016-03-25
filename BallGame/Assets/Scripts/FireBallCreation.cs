using UnityEngine;
using System.Collections;

public class FireBallCreation : MonoBehaviour {

    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    private GameObject fireball;

    private int fireCount;

	// Use this for initialization
	void Start () {
        fireCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 place;
        if (fireCount >= 100)
        {
            place = enemy.transform.position;
            place.y = 1.5f;
            Instantiate(fireball, place, transform.rotation);
            fireCount = 0;
            //print("Fire");
        }
        else
        {
            fireCount++;
        }
	}
}
