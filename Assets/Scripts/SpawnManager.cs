using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] asteroidPrefab;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            //Randomly generate spawn location
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int asteroidIndex = Random.Range(0, asteroidPrefab.Length);
            Instantiate(asteroidPrefab[asteroidIndex], spawnPos, asteroidPrefab[asteroidIndex].transform.rotation);
        }
    }
}
