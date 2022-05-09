using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ProjectileMovement : MonoBehaviour
{
    public ScoreManager ScoreManager;
    public UnityEvent EvtScore;
    public float speed;
    //public FlappyBirdController Player;

    void Start()
    {
        //Player = FindObjectOfType<FlappyBirdController>();
        ScoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        if (EvtScore == null)
        {
            EvtScore = new UnityEvent();
        }
        EvtScore.AddListener(ScoreManager.AddScore);  
    }
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            EvtScore.Invoke();
            Destroy(gameObject);
        }
    }
}
