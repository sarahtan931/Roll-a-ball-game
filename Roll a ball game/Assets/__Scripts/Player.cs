using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody _rb;
    public float speed;
    public Text countText;
    public Text winText;
    private int _count;
    private void Start()
    {
        _count = 0;
        //accessing component attatched to the game object
        _rb = GetComponent<Rigidbody>();
        CountText();
        winText.text = "";
       
    }

    void Update()
    {
        //reloads scene when all the pick ups are collected 
        if(_count >= 30)
        {
            //calling method to reload scene
            Invoke("ReloadScene", 3);
            Debug.Log("Scene being reloaded...");
        }

    }
    void FixedUpdate()
    {
        //get horizontal and vertical axis mapped to the arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //adding force to the rigid body
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        _rb.AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        //checking tag of pick up
       if(other.gameObject.CompareTag("Pick Up"))
        {
            //gets rid of pick up
            other.gameObject.SetActive(false);
            //incrementing count, then calling function to display it
            _count = _count + 1;
            CountText();
        }

        if (other.gameObject.CompareTag("Pick Up 2"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 2;
            CountText();
        }

        if (other.gameObject.CompareTag("Pick Up 3"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 3;
            CountText();
        }
    }
 void CountText()
    {
        //displaying how many points the player has gotten
        countText.text = "Count: " + _count.ToString();
        if (_count>= 30)
        {
            //if the player gets all the pick ups displaying that they win
            winText.text = "You WIN!";
        }
    }

    //function to restart the came after all pick ups have been collected 
    void ReloadScene()
    {
        _count = 0;
        CountText();
        Debug.Log("Scene Reset");
        //reloading the scene to the frame game
        SceneManager.LoadScene("Game");
    }
}