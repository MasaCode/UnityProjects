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

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 place;
        if (GameManager.Instance.FireBallCount >= 300)
        {
            place = enemy.transform.position;
            place.y = 1.5f;
            Instantiate(fireball, place, transform.rotation);
            GameManager.Instance.FireBallCount = 0;
            //print("Fire");
        }
        else
        {
            GameManager.Instance.FireBallCount++;
        }
	}
}
