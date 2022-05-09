using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public int currenthighscore;
    public ScoreManager manager;

    public TextMeshProUGUI playerScore;
    public TextMeshProUGUI highscore;

    public void Start()
    {
        currenthighscore = PlayerPrefs.GetInt("Highscore", currenthighscore);
    }
    public void Update()
    {   //Checks if new highscore and display highscore
        if(manager.score >= currenthighscore)
        {
            currenthighscore = manager.score;
            PlayerPrefs.SetInt("Highscore", currenthighscore);
            PlayerPrefs.Save();
        }
        //Display score in game over screen
        playerScore.text = "Your Score: " + manager.score;
        highscore.text = "High Score: " + currenthighscore;
    }

    public void Retry()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
}
