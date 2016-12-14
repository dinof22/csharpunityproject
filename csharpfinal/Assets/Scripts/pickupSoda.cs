using UnityEngine;
using System.Collections;

public class pickupSoda : MonoBehaviour {
    public GameObject playerObject; //object var
    public PlayerController playerController;
    public string playerTag = "Player"; //string var

	void Start () {
        playerController = playerObject.GetComponent<PlayerController>();
 	}
	
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            playerController.items.Add ("Soda");
            int buffChance = Random.Range(1, 3);
            switch (buffChance) //switch determines what teh buff items give you
            {
                case 1:
                    playerController.lives = playerController.lives + 3;
                    Destroy(gameObject);
                    break;
                case 2:
                    playerController.lives = 1;
                    Destroy(gameObject);
                    break;
                case 3:
                    playerController.jumpLimit = 10;
                    Destroy(gameObject);
                    break;
            }
        }
    }

}
