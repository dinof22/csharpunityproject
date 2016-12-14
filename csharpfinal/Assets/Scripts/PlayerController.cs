using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public int speed; //int variables
    private Rigidbody2D playerBody;
    public int jumpHeight;
    private int jumpCount;
    public int lives;
    private string floortag = "Floor"; //string var
    public int jumpLimit;
    public float buffTime = 10.0f;
    public List<string> items = new List<string>(); //this list holds strings of item names as you pick them up
    public Text item1Text; //object variables, controll hte text that displays what is being held in the item spot
    public Text item2Text;
    public Text item3Text;


	// This counts as a function without params
	void Start () {
        playerBody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	
	void Update () { //also is a function without params
        death(); //calls death funcion to find out if player is still alive or dead,  If dead, destroy player obj. If alive, you can control player.
        if (jumpLimit> 2) //jump limit is 2 so you can double jump
        {
            buffTime = buffTime - Time.deltaTime;
            if (buffTime < 0)
            {
                jumpLimit = 2;
                buffTime = 10.0f;
            }
        }
        if (items.Count == 1)
        {
            foreach (string item in items)
            {
                item1Text.text = "Item 1: " + item;
            }
        }
        if (items.Count == 2)
        {
            for (int u = 0; u < items.Count; u++)
            {
                if (u == 1)
                {
                    item2Text.text = "Item 2: " + items[u];
                }
            }
        }

    }
    void PlayerControls() //lots of functions without params
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerBody.velocity = new Vector3(-speed, playerBody.velocity.y, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerBody.velocity = new Vector3(speed, playerBody.velocity.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < jumpLimit)
            {
                playerBody.velocity = new Vector3(playerBody.velocity.x, jumpHeight, 0);
                jumpCount++;

            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.GetComponent<Animator>().SetTrigger("SwingTrigger");
        }
       
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(floortag))
        {
            jumpCount = 0;
        }
    }

    void OncollsionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(floortag)) //this function has (2) params to detect object collision
        {
            jumpCount = 0;
        }
    }
    void death() //another function without params
    {
        if(lives == 0)
        {
            Destroy(gameObject);
        } else //else clause
        {
            PlayerControls();
        }
    }
}
