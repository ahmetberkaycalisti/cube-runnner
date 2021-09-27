using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    
    // Start is called before the first frame update
    void Start()
    {
        // rb.useGravity = false;
        // rb.AddForce(0, 200, 500 );
    }

    // We marked this as "Fixed Update" because we 
    // are using it to mess with physics.
    // Update is called once per frame
    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) { 
            rb.AddForce(sidewaysForce * Time.deltaTime, 0,0);
        }

        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

    }


    

}
