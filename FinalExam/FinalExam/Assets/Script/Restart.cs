using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	public void ReLoad(){
		GameManager.Instance.IsGameOver = false;
		GameManager.Instance.isAdded = true;
		GameManager.Instance.Timer = 0f;
		GameManager.Instance.Score = 0;
		GameManager.Instance.count = 0;
		Application.LoadLevel ("Play");
	}
}
