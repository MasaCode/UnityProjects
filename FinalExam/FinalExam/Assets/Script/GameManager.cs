using UnityEngine;
using System.Collections;

public class GameManager : Singleton<GameManager> {

	public bool isAdded = true;
	public int count;

	private bool _isGameOver;
	public bool IsGameOver{
		get{ return _isGameOver;}
		set{ _isGameOver = value;}
	}


	private float _timer;
	public float Timer{
		get{ return _timer; }
		set{ _timer = value;}
	}

	private float _score;
	public float Score{
		get{ return _score;}
		set{ _score = value;}
	}

	void Start(){
		Timer = 0f;
		Score = 0;
		count = 0;
		IsGameOver = false;
	}

	void Update(){
		Timer += Time.deltaTime;
		if (!IsGameOver) {
			if (!isAdded) {
				if (Mathf.FloorToInt (Timer) % 15 == 0 && Timer != 0) {
					Score += 50;
					isAdded = true;
				}
			} else {
				count++;
			}

			if (count >= 60) {
				isAdded = false;
				count = 0;
			}
		}

	}


}
