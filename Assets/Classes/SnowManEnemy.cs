using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManEnemy : Controller
{
    private float moveSpeed;
    private Rigidbody2D rb;

    public SnowManEnemy(Rigidbody2D rigidbody)
    {
        rb = rigidbody;
        moveSpeed = 2.5f;
    }

    public void move(float dir)
    {
        rb.velocity = new Vector2(dir * moveSpeed, rb.velocity.y);
    }
}

