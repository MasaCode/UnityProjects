using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	[SerializeField]
	private float speedX;
	[SerializeField]
	private float speedZ;

	private Vector3 placement;


	// Use this for initialization
	void Start () {
		RandomSpeed ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 placement = transform.position;
		placement.x += speedX;
		placement.z += speedZ;

		if (placement.x >= 50f) {
			placement.x = 49f;
			RandomSpeed ();
			speedX = -speedX;
		} else if (placement.x <= -50f) {
			placement.x = -49f;
			RandomSpeed ();
		}

		if (placement.z >= 50f) {
			placement.z = 49f;
			RandomSpeed ();
			speedZ = -speedZ;
		} else if (placement.z <= -50f) {
			placement.z = -49f;
			RandomSpeed ();
		}

		transform.position = placement;
	}

	private void RandomSpeed(){
		speedX = Random.Range (0.1f, 0.5f);
		speedZ = Random.Range (0.1f, 0.5f);
	}
}
