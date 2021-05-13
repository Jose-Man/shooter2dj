using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesDisplay : MonoBehaviour
{
    public Text displayText = null;

    public void DisplayEnemiesLeft()
    {
        int enemiesToDefeat = GameManager.instance.enemiesToDefeat;
        int enemiesLeft = enemiesToDefeat - GameManager.instance.GetEnemiesDefeated();

        if (enemiesLeft > 0)
        {
            displayText.text = "Enemies to defeat: " + enemiesLeft.ToString();
        }
        else
        {
            displayText.text = "";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DisplayEnemiesLeft();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayEnemiesLeft();
    }
}
