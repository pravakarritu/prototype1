using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI operatorText;

    public bool isGameActive;
    private int score;
    private int restTime;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    private bool paused;





    void Start()
    {

        isGameActive = true;
        restTime = 30;
        timeText.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(true);
        operatorText.gameObject.SetActive(true);

        StartCoroutine(UpdateTime());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        timeText.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        operatorText.gameObject.SetActive(false);
        isGameActive = false;
    }

    IEnumerator UpdateTime()
    {
        while (isGameActive)
        {

            timeText.text = " Time: " + restTime;
            yield return new WaitForSeconds(1);
            restTime -= 1;
            if (restTime < 0)
            {
                GameOver();

            }
           
        }

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
