using UnityEngine;
using System.Collections;

public class GameManager : Singleton<GameManager> {

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

	// Use this for initialization
	void Start () {
        Timer = 0f;
        Health = 100;
	}
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;

        if (Health <= 0)
        {
            //Application.LoadLevel("Scene1");
        }
	}

    public void Attacked(int damage)
    {
        Health -= damage;
    }


}
