using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestinertiaTensor : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        
        rb = GetComponent< Rigidbody >();

    }//Start

    void FixedUpdate()
    {
        
        Debug.Log (this.name + " Inertia is " + rb.inertiaTensor);

        rb.angularVelocity = rb.inertiaTensor;

        transform.localScale += new Vector3( Input.GetAxis("Horizontal"),0,0 );

    }//FixedUpdate

}//TestinertiaTensor
