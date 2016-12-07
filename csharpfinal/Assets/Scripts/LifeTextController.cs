using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeTextController : MonoBehaviour {
    public Text lifeText;
    public GameObject player;
    public PlayerController playerController;


	void Start () {
        playerController = player.GetComponent<PlayerController>();
	}
	

	void Update () {
        lifeText.text = "lives: " + playerController.lives.ToString();
	}
}
