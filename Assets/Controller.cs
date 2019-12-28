using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Player player;

    //Start is called before the first frame update
    void Start()
    {
        player = new Player(GetComponent<Rigidbody2D>(), false);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        player.changeVelocity();

        if(Input.GetButton("Jump"))
        {
            player.jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("TileMap"))
        {
            player.setGrounded(false);
        }
    }
}
