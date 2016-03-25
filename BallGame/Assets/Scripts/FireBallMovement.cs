using UnityEngine;
using System.Collections;

public class FireBallMovement : MonoBehaviour {

    private float speed;

	// Use this for initialization
	void Start () {
        speed = Random.Range(-1.5f, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 place = transform.position;
        place.x += speed;
        place.z += speed;
        transform.position = place;
	}
}
