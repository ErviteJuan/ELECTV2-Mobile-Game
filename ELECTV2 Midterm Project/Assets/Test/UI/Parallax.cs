using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed;
    public Renderer ren;
    void Update()
    {
        ren.material.mainTextureOffset = new Vector2(Time.time * speed, 0f);
    }
}
