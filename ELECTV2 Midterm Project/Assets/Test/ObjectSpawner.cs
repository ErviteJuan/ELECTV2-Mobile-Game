using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    private float spawnDelay = 2f;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
    }
    void SpawnObjects()
    {
        Vector3 spawnLocation = new Vector2(12, Random.Range(-3, 3));
        Instantiate(objectPrefab, spawnLocation, objectPrefab.transform.rotation);
    }
  
}
