using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner2 : MonoBehaviour
{
    public GameObject objectPrefab;
    private float spawnDelay = 2f;
    private float spawnInterval = 1.5f;
    public float[] range;
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
    }
    void SpawnObjects()
    {
        int index = Random.Range(0, range.Length);
        Vector2 spawnLocation = new Vector2(12, range[index]);
        Instantiate(objectPrefab, spawnLocation, objectPrefab.transform.rotation);
    }
}
