using UnityEngine;
using System.Collections;

public class EnemyCreation : MonoBehaviour {

	[SerializeField]
	private GameObject ball;

	private bool isCreated = false;
	private int count;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!isCreated) {
			if (Input.GetKey ("n")) {
				Vector3 placement = RandomGenerate ();
				Instantiate (ball, placement, transform.rotation);

			}
		} else {
			count++;
		}

		if (count >= 30) {
			isCreated = false;
			count = 0;
		}

	}


	private Vector3 RandomGenerate(){
		float x, y, z = -2f;
		x = Random.Range (-13f,13f);
		y = Random.Range (-7f, 7f);
		isCreated = true;
		return new Vector3(x,y,z);
	}

}
