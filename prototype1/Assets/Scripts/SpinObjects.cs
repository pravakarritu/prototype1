using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjects : MonoBehaviour
{
    public float spinSpeed;

    // Update is called once per frame
    private GameManager gameManager;
    

    void Update()
    {
        
            transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
        
    }
}
