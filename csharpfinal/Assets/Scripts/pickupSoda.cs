using UnityEngine;
using System.Collections;

public class pickupSoda : MonoBehaviour {
    public GameObject playerObject;
    public PlayerController playerController;
    public string playerTag = "Player";
	void Start () {
        playerController = playerObject.GetComponent<PlayerController>();
 	}
	
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            Debug.Log("Player has touched this object");
            int buffChance = Random.Range(1, 3);
            switch (buffChance)
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
                    playerController.lives = 50;
                    Destroy(gameObject);
                    playerController.jumpLimit = 10;
                    break;
            }
        }
    }

}
