using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
    public void ReLoad()
    {
        GameManager.Instance.Timer = 0f;
        GameManager.Instance.Health = 100;
        GameManager.Instance.EnemyCount = 0;
        GameManager.Instance.FireBallCount = 0;
        GameManager.Instance.CoinCount = 0;
        GameManager.Instance.isGameOver = false;
        Application.LoadLevel("Scene1");
    }
}
