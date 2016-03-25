using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	private float speedX,speedY;

	void Start(){
		speedX = Random.Range(0.1f,0.5f);
		speedY = speedX;
	}

	// Update is called once per frame
	void Update () {
		float x = transform.position.x, y = transform.position.y;

		x += speedX;
		y += speedY;

		if (x >= 15f) {
			x = 15f;
			speedX = -speedX;
		}

		if (y >= 7.5f) {
			y = 7.5f;
			speedY = -speedY;
		} else if (y <= -7.5f) {
			y = -7.5f;
			speedY = -speedY;
		}
		transform.position = new Vector3 (x, y, transform.position.z);

		if (x <= -16f) {
			GameOver();
		}
	}


	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			//print("I get it");
			speedX = -speedX;
			//x = 19.5f;
			//transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		}
	}

	private void GameOver(){
		//print ("You lose the Game");
		GameManager.Instance.IsGameOver = true;
		Application.LoadLevel ("GameOver");
	}
}
