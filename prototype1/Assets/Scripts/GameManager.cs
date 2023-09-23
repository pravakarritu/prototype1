using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI operatorText;

    public bool isGameActive;
    private int score;
    private int restTime;


    void Start()
    {
        isGameActive = true;
        restTime = 60;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
