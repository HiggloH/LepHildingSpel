using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Player player;

    //Start is called before the first frame update
    void Start()
    {
        player = new Player(GetComponent<Rigidbody2D>(), false);
        
    }

    
    private void FixedUpdate()
    {
        player.changeVelocity();
        
        if(Input.GetButton("Jump"))
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
    }

    
}
