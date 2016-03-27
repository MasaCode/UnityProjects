using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateUI : MonoBehaviour {

    [SerializeField]
    private Text TimerLabel;

    [SerializeField]
    private Text HealthLabel;

    [SerializeField]
    private Text CoinLabel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    TimerLabel.text = FormatToTimer(GameManager.Instance.Timer);
        HealthLabel.text = "Life : " + GameManager.Instance.Health.ToString() + "%";
        CoinLabel.text = "Coin : " + GameManager.Instance.CoinCount.ToString();
	}

    private string FormatToTimer(float time)
    {
        return string.Format("{0}:{1:00}", Mathf.FloorToInt(time / 60), Mathf.FloorToInt(time % 60));
    }

}
