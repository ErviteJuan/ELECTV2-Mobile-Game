using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    public PlayerController player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        player.playerHealth -= 1;
        Handheld.Vibrate();
    }
}
