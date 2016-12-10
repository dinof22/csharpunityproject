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
                    JumpBuff ();
                    Destroy(gameObject);
                    break;
            }
        }
    }
    void JumpBuff ()
    {
        float buffTime = 10.0f;
        while (buffTime > 0)
        {
            playerController.jumpLimit = 10;
            buffTime = buffTime - Time.deltaTime;
        }
        if(buffTime < 0)
        {
            playerController.jumpLimit = 2;
        }
    }
}
