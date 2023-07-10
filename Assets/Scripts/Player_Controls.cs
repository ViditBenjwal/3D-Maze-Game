using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class Player_Controls : MonoBehaviour
{
    private Rigidbody rb;
    
    private int health;
    private float movementX;
    private float movementY;
    public float speed = 0;
    public TextMeshProUGUI healthText;
    public GameObject winTextObj;
    public GameObject loseTextObj;
    public float timeLeft = 60.0f;
    public TextMeshProUGUI Timer;
    


    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      health = 3;

      
      SetHealthText();
      winTextObj.SetActive(false);
      loseTextObj.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y; 
    }
    void OnCollisionEnter(UnityEngine.Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Spike")
        {
            health -= 1;
            SetHealthText();
            
        }
    }

    void SetHealthText()
    {
        healthText.text = "Health : " + health.ToString(); 
        if (health <= 0)
        {
            loseTextObj.SetActive(true);
            FindObjectOfType<gameManager>().EndGame();
            
           
            
            
        }
    }

   
        
    
    void Update()
    {
        timeLeft -= Time.deltaTime;
        Timer.text = "Time Left : " + (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
           loseTextObj.SetActive(true);
           FindObjectOfType<gameManager>().EndGame();
           
        }
    }    


    void FixedUpdate()
    {

        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            timeLeft += 5;

            
            
            
        }    
        

    }  
      
}
