using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
	public float maxSpeed = 5;
    private Vector3 location;
	private float maxX = 250;

    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		location = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		transform.Translate (location * moveSpeed);
	}
}
