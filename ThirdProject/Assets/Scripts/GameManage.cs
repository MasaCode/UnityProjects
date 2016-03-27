using UnityEngine;
using System.Collections;

public class GameManage : Singleton<GameManage> {

    private float GametimeRemaining;

    public float GameTimeRemaining
    {
        get { return GametimeRemaining; }
        set { GametimeRemaining = value; }
    }

    private float maxTime = 5 * 60; // In seconds.

    private int coinnumber;
    public int CoinNumber
    {
        get { return coinnumber; }
        set { coinnumber = value; }
    }


	// Use this for initialization
	void Start () {
        GameTimeRemaining = maxTime;
        CoinNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
        GameTimeRemaining -= Time.deltaTime;

        if (GameTimeRemaining <= 0f)
        {
            Application.LoadLevel(Application.loadedLevel);
            GameTimeRemaining = maxTime;
            CoinNumber = 0;
        }
	}
}
