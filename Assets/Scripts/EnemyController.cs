using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class EnemyController : MonoBehaviour
{
    public float MoveSpeed = 5f;

    private GameObject player;
    private Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Player"))
        {
            Destroy(player);
            Player.dead = true;
        }

       
    }

   
}
