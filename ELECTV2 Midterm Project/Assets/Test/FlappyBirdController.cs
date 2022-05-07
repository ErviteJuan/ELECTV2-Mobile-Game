using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlappyBirdController : MonoBehaviour
{
    public GameObject Player;
    public Transform Position1;
    public Transform Position2;
    public bool IsUp;
    public float timerDuration;
    [SerializeField] float timer;

    public float speed;
    public Text text;
    public int score;

    public void PlayerUp()
    {
        timer = timerDuration;
        IsUp = true;
        Player.transform.position = Vector2.MoveTowards(Player.transform.position, Position2.transform.position, Time.deltaTime * speed);
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && IsUp == true)
        {
            IsUp = false;
        }
        if(IsUp == false)
            Player.transform.position = Vector2.MoveTowards(Player.transform.position, Position1.transform.position, Time.deltaTime * speed);
        text.text = score.ToString();
    }
}
