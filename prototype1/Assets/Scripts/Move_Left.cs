using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Left : MonoBehaviour
{
    private Player_Movement playerControllerScript;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<Player_Movement>();


    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);

          //  transform.Translate(Vector3.forward * Time.deltaTime * speed);
            
        }
    }
}
