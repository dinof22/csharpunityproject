using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EnemiesLeftController : MonoBehaviour {
    public Text enemiesLeftText;
    public List<string> enemiesLeft = new List<string> (); //list of enemies left
    private int enemyCounter;
    public List<GameObject> allEnemies = new List<GameObject>(); //list of pbjects, total ememies
    public GameObject enemy1;
    public GameObject enemy2;
    public Text winText;
    public bool win;
	
	void Start () {
        allEnemies.Add(enemy1); //adding enemy objects
        allEnemies.Add(enemy2);
        win = false;

	}
	
	
	void Update () {
	    if (allEnemies[0] == null && allEnemies [1] == null)
        {
            win = true;
        }
        switch (win) //switch statement
        {
            case true:
                winText.enabled = true;
                break;
        }
        enemiesLeftText.text = "Enemies Left: " + enemyCounter.ToString();
	}

    public void CheckEnemies()
    {
        enemyCounter = 0;
        foreach (string enemy in enemiesLeft) //for each loop looping throught enemy list
        {
            enemyCounter = enemyCounter + 1; 
        }
    }
}
