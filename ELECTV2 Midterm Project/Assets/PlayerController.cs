using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    public Transform Position1;
    public Transform Position2;
    public bool IsUp;
    public float timerDuration;
    [SerializeField] float timer;

    public Text text;
    public int score;

    //Moves the player up the to the second position
    public void PlayerUp()
    {
        timer = timerDuration;
        IsUp = true;
        Player.transform.position = Position2.position;
    }

    private void Update()
    {
        //Checks if the player stops using the mic
        timer -= Time.deltaTime;
        if (timer <= 0 && IsUp == true)
        {
            IsUp = false;
            Player.transform.position = Position1.position;
        }
        text.text = score.ToString();
    }
}
