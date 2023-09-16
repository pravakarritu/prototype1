using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Movement : MonoBehaviour
{
    public float speed = 5.0f; 

    public float turnSpeed; 

    public float horizontalInput; 
    
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

         // Move the vehicle   
         transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //  transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput );
    }
}
