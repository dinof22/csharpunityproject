using UnityEngine;
using System.Collections;

public class ThornController : MonoBehaviour {
    public GameObject player; //object var
    public PlayerController playerController;
    private string playerTag = "Player"; //string var
	
	void Start () {
        playerController = player.GetComponent<PlayerController>();
	}
	
	
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D other) //method with 2 params
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            playerController.lives = playerController.lives - 1;
        }

    }
}
