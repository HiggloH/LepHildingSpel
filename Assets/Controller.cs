using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5;
    public float JumpSpeed = 2.5f;

    public bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.AddForce(-Vector2.down * JumpSpeed);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "TileMap" && isGrounded == false)
        {
            Debug.Log("YEET");
            isGrounded = true;
        }
    }
}
