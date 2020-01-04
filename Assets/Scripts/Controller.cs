using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Player player;
    private int nextSceneToLoad;

    //Start is called before the first frame update
    void Start()
    {
        player = new Player(GetComponent<Rigidbody2D>(), false);
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    

    
    private void FixedUpdate()
    {
        player.changeVelocity();

        if(Input.GetKeyDown("d") && player.getDirection() != "left")
        {
            player.turn(gameObject);
            player.setDirection("left");
        }

        else if (Input.GetKeyDown("a") && player.getDirection() != "right")
        {
            player.turn(gameObject);
            player.setDirection("right");
        }

        if (Input.GetButton("Jump"))
        {
            if (player.getGrounded() == true)
            {
                player.jump();
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("TileMap"))
        {
            player.setGrounded(true);
            CameraStoper.move = true;
        }
        if (collision.gameObject.tag == ("Enemy"))
        {
            player.jump(); 

        }
        if(collision.gameObject.tag == ("ColliderOfDeath"))
        {
            Destroy(gameObject);
            Player.dead = true;
        }
        if(collision.gameObject.tag == "PowerUp1")
        {
            player.setJumpHeight(11);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Win")
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }

    
}
