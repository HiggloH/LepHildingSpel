using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public float jumpSpeed;
    public bool isGrounded;

    public Player(Rigidbody2D rigidbody, bool grounded)
    {
        rb = rigidbody;
        isGrounded = grounded;
        moveSpeed = 5f;
        jumpSpeed = 5f;
    }

    public void changeVelocity()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);
    }

    public void jump()
    {
        
        if (isGrounded == true)
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            isGrounded = false;
            
        }
    }

    public void setGrounded(bool grounded)
    {
        isGrounded = grounded;
    }

}
