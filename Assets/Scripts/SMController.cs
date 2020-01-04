using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMController : MonoBehaviour
{
    private SnowManEnemy sm;
    private float direction; 
    void Start()
    {
        sm = new SnowManEnemy(GetComponent<Rigidbody2D>());
        direction = MainController.directions["left"];
    }
    void Update()
    {
        sm.move(direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Player.dead = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Edge")
        {
            direction = direction * -1;
        }
    }

    public float getDirection()
    {
        return direction;
    }

    public void setDirection(float f)
    {
        direction = f;
    }
}
