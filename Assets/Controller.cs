using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 5;
    private float JumpSpeed = 5f;

    private bool isGrounded = true;
    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = false;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);

        if(Input.GetButton("Jump") && isGrounded == true)
        {
            rb.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("TileMap") && isGrounded == false)
        {
            isGrounded = true;
        }
    }
}
