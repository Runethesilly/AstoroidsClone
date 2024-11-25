using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{

    //Splitting Variables
    public GameObject smallerSnowflake;
    public int smallerSnowflakesToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            SpawnSmaller(smallerSnowflakesToSpawn);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void SpawnSmaller(int numberToSpawn)
    {
        if(smallerSnowflake != null)
        {
            for(int i = 0; i < numberToSpawn; i++)
            {
                Instantiate(smallerSnowflake, transform.position, transform.rotation);
            }

        }
    }
}
