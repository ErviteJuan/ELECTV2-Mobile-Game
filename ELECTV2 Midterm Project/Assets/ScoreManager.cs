using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public int score;

    private void Start()
    {
        score = 0;
    }

    public void AddScore()
    {
        Debug.Log("Added Score!");
        score += 1;
    }
}
