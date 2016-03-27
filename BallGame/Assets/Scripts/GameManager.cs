using UnityEngine;
using System.Collections;

public class GameManager : Singleton<GameManager> {

    public bool isGameOver = false;

    private float _timer;
    public float Timer
    {
        get { return _timer; }
        set { _timer = value; }
    }

    private int _health;
    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }

    private int _enemyCount;
    public int EnemyCount
    {
        get { return _enemyCount; }
        set { _enemyCount = value; }
    }

    public int EnemyMax = 10;

    private int _fireBallCount;
    public int FireBallCount
    {
        get { return _fireBallCount; }
        set { _fireBallCount = value; }
    }

    private int _coinCount;
    public int CoinCount
    {
        get { return _coinCount; }
        set { _coinCount = value; }
    }



	// Use this for initialization
	void Start () {
        Timer = 0f;
        Health = 100;
        EnemyCount = 0;
        FireBallCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;
        if (Health <= 0 && !isGameOver)
        {
            isGameOver = true;
            Application.LoadLevel("GameOver");
        }

        if (CoinCount == EnemyMax)
        {
            Application.LoadLevel("Win");
        }


	}

    public void Attacked(int damage)
    {
        Health -= damage;
    }


}
