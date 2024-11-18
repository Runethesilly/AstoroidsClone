using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //turning variables
    public float turnSpeed;
    public float horizontalInput;

    //Thrust variables
    public float thrustSpeed;
    public float verticalInput;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Rotation
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

    }
    private void FixedUpdate()
    {
        //Thrust
        verticalInput = Input.GetAxis("Vertical");

        rb.AddRelativeForce(Vector3.forward * thrustSpeed * verticalInput);
    }
}
