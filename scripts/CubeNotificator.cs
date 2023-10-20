using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeNotificator : MonoBehaviour
{
    public delegate void action();
    public event action OnNotGroup1Enter; 
    public event action OnGroup1Enter; 

    private int playerPunctuation = 0;
    public Text playerPunctuationText;

    // Start is called before the first frame update
    void Start()
    {
        playerPunctuation = 0;
        updatePunctuationText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.gameObject.tag == "sphere_group_1") 
        {
            playerPunctuation += 5;
            Destroy(collision.collider.gameObject);
            // Debug.Log("Player punctuation: " + playerPunctuation);
            updatePunctuationText();
        }
        else 
        {
            OnNotGroup1Enter();
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "sphere_group_1") 
        {
            OnGroup1Enter();
        }
        else
        {
            // OnNotGroup1Enter();
            playerPunctuation += 10;
            Destroy(other.gameObject);
            // Debug.Log("Player punctuation: " + playerPunctuation);
            updatePunctuationText();
        }
        
    }

    void updatePunctuationText()
    {
        playerPunctuationText.text = "Player punctuation: " + playerPunctuation;
    }
}
