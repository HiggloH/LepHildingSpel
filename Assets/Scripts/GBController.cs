using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GBController : MonoBehaviour
{
    private GingerBreadEnemy gb;

    

    void Start()
    {
        gb = new GingerBreadEnemy(GetComponent<Rigidbody2D>());
        
    }

    // Update is called once per frame
    void Update()
    {
        gb.move("left");
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
}
