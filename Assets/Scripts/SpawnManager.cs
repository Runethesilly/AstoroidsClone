using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] asteroidPrefab;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    public int AsteroidCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       AsteroidCount = GameObject.FindObjectsByType<AsteroidController>(0).Length;

        if(AsteroidCount == 0)
        {
           Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int asteroidIndex = Random.Range(0, asteroidPrefab.Length);
            Instantiate(asteroidPrefab[asteroidIndex], spawnPos, asteroidPrefab[asteroidIndex].transform.rotation);
        }

    }
}
