using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIUpdateforGameOver : MonoBehaviour {

	[SerializeField]
	private Text FinalScoreLabel;


	// Use this for initialization
	void Start () {
		FinalScoreLabel.text = "Your Final Score : " + GameManager.Instance.Score.ToString();
	}
}
