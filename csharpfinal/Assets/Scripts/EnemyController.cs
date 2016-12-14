using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    //enemy life count numbers are stored within an array
    int[] enemyLife = new int[4] {0, 1, 2, 3 };
    public int life;
    private int lifePointer;
    public string playerTag = "Player"; //string var
    public GameObject playerObject; //object var
    public GameObject gamecontroller;

	void Start () {
        lifePointer = 3;
        gamecontroller.GetComponent<EnemiesLeftController>().enemiesLeft.Add("Enemy1");
        gamecontroller.GetComponent<EnemiesLeftController>().CheckEnemies();
	}
	
	
	void Update () {
        life = enemyLife[lifePointer];
        if (life == 0)
        {
            gamecontroller.GetComponent<KilltextController>().i = gamecontroller.GetComponent<KilltextController>().i + 1;
            gamecontroller.GetComponent<EnemiesLeftController>().enemiesLeft.RemoveAt(0);
            gamecontroller.GetComponent<EnemiesLeftController>().CheckEnemies();
            Destroy(gameObject);
        }
        if(lifePointer < 0)
        {
            lifePointer = 0;
        }

	}
    private void OnTriggerStay2D(Collider2D other) //function with 2 params
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                lifePointer = lifePointer - 1;
                gameObject.GetComponent<Animator>().SetTrigger("EnemyHit");
            }
        }
    }
}
