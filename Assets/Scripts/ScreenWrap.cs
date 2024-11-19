using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xMax)
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                xMin
                );
        }
        if (transform.position.x > xMin)
        {
            transform.position = new Vector3(
            xMax,
                transform.position.x,
                transform.position.y
                );
        }



    }
}
