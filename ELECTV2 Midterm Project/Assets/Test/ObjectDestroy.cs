using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDestroy : MonoBehaviour
{
    public PlayerController player;
    public Slider playerHealth;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        player.playerHealth -= 1;
        Handheld.Vibrate();
        playerHealth.value -= 1;
    }
}
