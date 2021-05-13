using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    public Text displayText = null;
    public Health playerHealth;

    public void DisplayLives()
    {
        
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
            displayText.text = "Lives: " + playerHealth.currentLives.ToString();
        }
        else
        {
            displayText.text = "Lives: 0";
        }
    }

    private void Start()
    {
        DisplayLives();
    }

    private void Update() 
    {
        DisplayLives();
    }
}
