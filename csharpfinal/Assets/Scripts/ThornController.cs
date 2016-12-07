using UnityEngine;
using System.Collections;

public class ThornController : MonoBehaviour {
    public GameObject player;
    public PlayerController playerController;
    private string playerTag = "Player";
	
	void Start () {
        playerController = player.GetComponent<PlayerController>();
	}
	
	
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            playerController.lives = playerController.lives - 1;
        }

    }
}
