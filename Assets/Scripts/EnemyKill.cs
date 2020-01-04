using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyKill : MonoBehaviour
{
    public GameObject Enemy;
    
    public Vector2 offset;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(gameObject);
            Destroy(Enemy);
            
        } 
    }

    private void Update()
    {
        transform.position = Enemy.transform.TransformPoint(offset);
    }   
    
}
