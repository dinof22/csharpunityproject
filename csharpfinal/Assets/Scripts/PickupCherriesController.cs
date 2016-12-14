﻿using UnityEngine;
using System.Collections;

public class PickupCherriesController : MonoBehaviour {
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
            playerController.items.Add("Cherries");
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
                    playerController.jumpLimit = 10;
                    Destroy(gameObject);
                    break;
            }
        }
    }
}