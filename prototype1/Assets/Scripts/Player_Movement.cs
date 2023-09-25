using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;
    public float jumpForce;
    public bool gameOver;
    public float speed = 1.0f;
    public float horizontalInput;
    public float verticalInput;
    public float forwardsForce = 40f;
    public float sidewaysForce = 40f;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public TextMeshProUGUI operatorText;
    private bool operator_collected = false;
    private string operatortext;
    private GameManager gameManager;




    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()

    {
        
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                playerRb.AddForce(0, 0, forwardsForce * Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {

                playerRb.AddForce(0, 0, -forwardsForce * Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                playerRb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                playerRb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        

    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("multiplication"))
        {
            operatortext = "X";
            operatorText.text = "Operator collected : " + operatortext;
            operator_collected = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("division"))
        {
            operatortext = "/";
            operatorText.text = "Operator collected : " + operatortext;
            operator_collected = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("ten"))
        { if (operator_collected)
            {
                if (operatortext == "/")
                {
                    score /= 10;
                }


                if (operatortext == "X")
                {
                    score *= 10;

                }
                scoreText.text = "Score: " + score;
                operator_collected = false;
                operatorText.text = "Operator collected : ";


            }
            else
            {
                score += 10;
                scoreText.text = "Score: " + score;

            }
            Destroy(other.gameObject);



        }
        if (other.gameObject.CompareTag("twenty"))
        {


            if (operator_collected)
            {
                if (operatortext == "/")
                {
                    score /= 20;
                }


                if (operatortext == "X")
                {
                    score *= 20;

                }
                scoreText.text = "Score: " + score;
                operator_collected = false;
                operatorText.text = "Operator collected : ";


            }
            else
            {
                score += 20;
                scoreText.text = "Score: " + score;
            }
            Destroy(other.gameObject);

        }

        if (other.gameObject.CompareTag("fifty"))
        {

            if (operator_collected)
            {
                if (operatortext == "/")
                {
                    score /= 50;
                }


                if (operatortext == "X")
                {
                    score *= 50;

                }
                scoreText.text = "Score: " + score;
                operator_collected = false;
                operatorText.text = "Operator collected : ";



            }
            else
            {
                score += 50;
                scoreText.text = "Score: " + score;
            }
            Destroy(other.gameObject);
        }
        

       
        
        

        
    }



}
