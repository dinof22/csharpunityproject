using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeTextController : MonoBehaviour {
    public Text lifeText;
    public GameObject player; //object var
    public PlayerController playerController;
    public int lives;


	void Start () {
        playerController = GetPlayerController();
	}
	

	void Update () {
        lives = GetLife ();
        lifeText.text = "lives: " + lives.ToString();
	}
    //these functions have a return (have returnz)
     int GetLife ()
    {
        return playerController.lives;
    }
    PlayerController GetPlayerController()
    {
        return player.GetComponent<PlayerController> ();
    }
}
