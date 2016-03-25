using UnityEngine;
using System.Collections;

public class BarMovement : MonoBehaviour {

	[SerializeField]
	private float speed;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		//print(Input.GetAxis("Vertical"));
		if (Input.GetKey (KeyCode.UpArrow)) {
			temp.y += speed;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			temp.y -= speed;
		}


		if (temp.y <= -7.5f) {
			temp.y = -7.5f;
		} else if (temp.y >= 7.5f) {
			temp.y = 7.5f;
		}


		transform.position = new Vector3 (temp.x, temp.y, temp.z);
	}

	void OnTriggerEnter(Collider collider)
	{
		float size;
		if (collider.gameObject.tag == "Enemy")
		{
			size = transform.localScale.y;
			size--;
			if(size <= 3){
				size = 3;
			}
			transform.localScale = new Vector3(transform.localScale.x,size,transform.localScale.z);
		}
	}

}
