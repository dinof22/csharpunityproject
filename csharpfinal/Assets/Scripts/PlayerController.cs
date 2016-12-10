using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public int speed;
    private Rigidbody2D playerBody;
    public int jumpHeight;
    private int jumpCount;
    public int lives;
    private string floortag = "Floor";
    public int jumpLimit;
    public float buffTime = 10.0f;

	// This counts as a function without params
	void Start () {
        playerBody = gameObject.GetComponent<Rigidbody2D>();
        jumpLimit = 2;
	}
	
	// Update is called once per frame
	void Update () {
        death();
        if(jumpLimit> 2)
        {
            buffTime = buffTime - Time.deltaTime;
            if (buffTime < 0)
            {
                jumpLimit = 2;
                buffTime = 10.0f;
            }
        }
        

    }
    void PlayerControls()
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
       
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(floortag))
        {
            jumpCount = 0;
        }
    }
    void death()
    {
        if(lives == 0)
        {
            Destroy(gameObject);
        } else
        {
            PlayerControls();
        }
    }
}
