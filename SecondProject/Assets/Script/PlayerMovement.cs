using UnityEngine;
using System.Collections;

public class Playermovement : MonoBehaviour {
    public float speed;
    private Vector3 movement;
    private Vector3 check;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        check = movement * speed;
        transform.Translate(check);

	}
}
