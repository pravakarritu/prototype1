using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objectPrefabs;
    private float spawnDelay = 1;
    private float spawnInterval = 1.0f;

    private Player_Movement playerControllerScript;

    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<Player_Movement>();
    }

    // Update is called once per frame

    
    void SpawnObjects()
    {
        Vector3 spawnLocation = new Vector3(Random.Range(-110,-60), Random.Range(5, 30), Random.Range(40, 320));
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        if (!playerControllerScript.gameOver)
        {
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }
    }

   
}
