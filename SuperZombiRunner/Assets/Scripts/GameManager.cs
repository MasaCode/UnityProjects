using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class GameManager : MonoBehaviour {

    //I diceded not to use TimeManager Because there is an error when I restart....

    public GameObject PlayerPrefab;

    public Text ContinueText; //Start text..
    public Text ScoreText;

    private float timeElapsed = 0f;
    private float bestTime = 0f;
    private float blinkTime = 0f;
    private bool isBlink;
    private bool beatBestTime;
    //private TimeManager _timeManager;
    private bool gameStarted;

    private GameObject player;
    private GameObject floor;
    private Spawner spawner;

    public void Awake() {
        floor = GameObject.Find("Foreground");
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        //_timeManager = GetComponent<TimeManager>();
    }


    public void Start()
    {
        var floorHeight = floor.transform.localScale.y;

        var pos = floor.transform.position;
        pos.x = 0;
        pos.y  = -((Screen.height / PixelPerfectCamera.PixelsToUnits) / 2) + (floorHeight/2);
        floor.transform.position = pos;

        spawner.active = false;

        Time.timeScale = 0; // To Start the game;
        gameStarted = false;
        //ResetGame();

         ContinueText.text = "PRESS ANY BUTTON TO START";
         bestTime = PlayerPrefs.GetFloat("BestTime");
    }

    public void Update()
    {
        if (!gameStarted && Time.timeScale == 0)
        {
            if (Input.anyKeyDown)
            {
               // _timeManager.ManipulateTime(1, 1f); 
                Time.timeScale = 1;
                ResetGame();
                
            }
        }

        if (!gameStarted)
        {
            blinkTime++;

            if (blinkTime % 40 == 0)
                isBlink = !isBlink;

            ContinueText.canvasRenderer.SetAlpha(isBlink ? 0 : 1);

            var textColor = beatBestTime ? "#FF0" : "#000";
            //ScoreText.text = "TIME : " + FormatTime(timeElapsed) + "\n<color=" + textColor + ">" + "BEST : " + FormatTime(bestTime) + "</color>";

            ScoreText.text = "TIME : " + FormatTime(timeElapsed) + "\nBEST : " + FormatTime(bestTime);
        }
        else
        {
            timeElapsed += Time.deltaTime;
            ScoreText.text = "TIME : " + FormatTime(timeElapsed);
        }


    }

    public void OnPlayerKilled()
    {
        spawner.active = false;

        var PlayerDestroyScript = player.GetComponent<DestroyOffscreenObject>();
        PlayerDestroyScript.DestroyCallback -= OnPlayerKilled;

        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        //_timeManager.ManipulateTime(0, 5.5f);
        
        Time.timeScale = 0; 

        gameStarted = false;

        ContinueText.text = "PRESS ANY BUTTON TO RESTART";
        if (timeElapsed > bestTime)
        {
            bestTime = timeElapsed;
            PlayerPrefs.SetFloat("BestTime", bestTime);
            beatBestTime = true;
        }
    }

    private void ResetGame(){
        spawner.active = true;

        player = GameObjectUtil.Instantiate(PlayerPrefab,new Vector3(0,((Screen.height/PixelPerfectCamera.PixelsToUnits) / 2) + 50,0));

        var PlayerDestroyScript  = player.GetComponent<DestroyOffscreenObject>();
        PlayerDestroyScript.DestroyCallback += OnPlayerKilled;

        gameStarted = true;

        ContinueText.canvasRenderer.SetAlpha(0);

        timeElapsed = 0f;
        beatBestTime = false;
    }

    public string FormatTime(float value){

        TimeSpan t = TimeSpan.FromSeconds(value);
        return string.Format("{0:D2}:{1:D2}",t.Minutes,t.Seconds);
    }

}
