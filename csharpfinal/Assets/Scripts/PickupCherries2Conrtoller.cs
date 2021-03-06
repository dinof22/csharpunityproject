﻿using UnityEngine;
using System.Collections;
//essentially the same as the first cherries script
public class PickupCherries2Conrtoller : MonoBehaviour {
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
            playerController.items.Add("Cherries"); //add items to list
            int buffChance = Random.Range(1, 3);
            switch (buffChance) //switch
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