using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI ScoreTextUI;
    public ScoreManager Manager;

    private void Update()
    {
        ScoreTextUI.text = "Score: " + Manager.score.ToString();
    }

}
