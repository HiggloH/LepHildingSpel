using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GBController : MonoBehaviour
{
    private GingerBreadEnemy gb;
    private float direction;

    void Start()
    {
        gb = new GingerBreadEnemy(GetComponent<Rigidbody2D>());
        direction = MainController.directions["left"];

    }

    // Update is called once per frame
    void Update()
    {
        gb.move(direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Player.dead = true;
        }
        if(collision.gameObject.tag == ("ColliderOfDeath"))
        {
            Destroy(gameObject);
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
