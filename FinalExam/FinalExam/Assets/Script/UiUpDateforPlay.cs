using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UiUpDateforPlay : MonoBehaviour {

	[SerializeField]
	private Text TimerLabel;

	[SerializeField]
	private Text ScoreLabel;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		TimerLabel.text = FormatTimer (GameManager.Instance.Timer);
		ScoreLabel.text = "Score : " + GameManager.Instance.Score.ToString ();
	}


	private string FormatTimer(float TimeInSecond){
		return string.Format ("{0}:{1:00}", Mathf.FloorToInt (TimeInSecond / 60), Mathf.FloorToInt (TimeInSecond % 60));
	}
}
