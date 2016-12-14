using UnityEngine;
using System.Collections;

public class Enemy2Controller : MonoBehaviour {
    public GameObject player;
    public bool[] health = new bool[4] { false, false, false, false }; //array of booleans for health
    public int healthCounter;
    public GameObject gameController; //game object var

	void Start () {
        healthCounter = 3;
        gameController.GetComponent<EnemiesLeftController>().enemiesLeft.Add("Enemy2"); //adds to enemiesLeft list
        gameController.GetComponent<EnemiesLeftController>().CheckEnemies();
	}
	

	void Update () {
        CheckHealth();
	}
    void CheckHealth()
    {
        if (healthCounter <= 0)
        {
            health[0] = true;
            gameController.GetComponent<KilltextController>().i = gameController.GetComponent<KilltextController>().i + 1;
            gameController.GetComponent<EnemiesLeftController>().enemiesLeft.RemoveAt(0); //Removing enemy from list
            gameController.GetComponent<EnemiesLeftController>().CheckEnemies();
            Destroy(gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                healthCounter = healthCounter - 1;
            }
        }
    }
}
