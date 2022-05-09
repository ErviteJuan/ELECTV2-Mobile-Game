using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public int currenthighscore = 0;
    public ScoreManager manager;

    public TextMeshProUGUI playerScore;
    public TextMeshProUGUI highscore;

    public void Update()
    {   //Checks if new highscore and display highscore
        if(manager.score >= currenthighscore)
        {
            currenthighscore = manager.score;
            highscore.text = "High Score: " + currenthighscore;
        }
        //Display score in game over screen
        playerScore.text = "Your Score: " + manager.score;
    }
}
