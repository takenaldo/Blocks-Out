using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject holder;

    public bool isGameOver = false;
    public bool playerWins = false;

    public GameObject dialogGameOver;
    public GameObject dialogYouWin;

    public GameObject blocks;

    public int current_level = 1;
    public float freezedBallTimeout = 3f;

    public bool isMoving = false;

    public int levels = 9;

    public static int LANGUAGE_EN = 0;
    public static int LANGUAGE_RU = 1;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkGameStatus();
    }


    private void checkGameStatus()
    {
        if (isGameOver)
        {
            dialogGameOver.SetActive(true);
            

            //            Reset();
        }

        if (playerWins)
        {
            dialogYouWin.SetActive(true);
            if (current_level >= Helper.getHighScore())
                Helper.updateLevel();

            //            Reset();
        }


    }

    private void Reset()
    {
        isGameOver = false;
        playerWins = false;
        blocks.SetActive(false);
    }

    public void setMovingTrue()
    {
        isMoving = true;
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("hint"))
        {
            go.SetActive(false);
        }

    }
}
