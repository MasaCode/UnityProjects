using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpDateUI : MonoBehaviour {

    [SerializeField]
    private Text timerLabel;
    [SerializeField]
    private Text CoinLabel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timerLabel.text = FormatTime(GameManage.Instance.GameTimeRemaining);
        CoinLabel.text = GameManage.Instance.CoinNumber.ToString();
	}

    private string FormatTime(float timeInSeconds)
    {
        return string.Format("{0}:{1:00}", Mathf.FloorToInt(timeInSeconds / 60), Mathf.FloorToInt(timeInSeconds % 60));
    }
}
