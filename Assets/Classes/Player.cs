using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed;
    private float jumpSpeed;
    private string facingDirection;
    public bool isGrounded;
    public static bool dead;
    
   

    public Player(Rigidbody2D rigidbody, bool grounded)
    {
        rb = rigidbody;
        
        isGrounded = grounded;
        moveSpeed = 5f;
        jumpSpeed = 7f;
        facingDirection = "left";
    }

    public void changeVelocity()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);
        
    }

    public void jump()
    {
        rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        isGrounded = false;
    }

    public void setGrounded(bool grounded)
    {
        isGrounded = grounded;
    }

    public bool getGrounded()
    {
        return isGrounded;
    }
    public void setJumpHeight(float height)
    {
        jumpSpeed = height;
    }
    public void turn(GameObject player)
    {
        player.transform.Rotate(0, 180, 0);
    }
    
    public void setDirection(string s)
    {
        facingDirection = s;
    }
    
    public string getDirection()
    {
        return facingDirection;
    }
}
