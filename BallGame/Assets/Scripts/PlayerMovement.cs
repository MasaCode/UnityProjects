using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*
        Vector3 place = new Vector3 (Input.GetAxis ("Horizontal"), 0f, Input.GetAxis ("Vertical"));
		transform.Translate(place*speed);
         */
        float x = transform.position.x, y = transform.position.y, z = transform.position.z;
      

        if (Input.GetKey(KeyCode.RightArrow))
        {
            x += speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            x -= speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            z += speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            z -= speed;
        }

        transform.position = new Vector3(x, y, z);
	}
}
