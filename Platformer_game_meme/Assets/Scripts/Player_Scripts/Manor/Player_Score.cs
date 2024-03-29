﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{

    private float timeLeft = 300;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;

    void Start()
    {
        timeLeftUI = GameObject.Find("TimeLeft");
        playerScoreUI = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left : " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score : " + playerScore);
        if (timeLeft < 0.1f)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
    void OnTriggerEnter2D (Collider2D trig)
    {
        if (trig.gameObject.name == "EndLevel")
        {
            CountScore();
            SceneManager.LoadScene("VictoryScene");
        }
        if (trig.gameObject.name == "Upvote")
        {
            playerScore += 10;
            Destroy(trig.gameObject);
        }
    }
    void CountScore()
    {
        playerScore = playerScore + ((int)timeLeft * 5);
        Debug.Log(playerScore);
    }
}
