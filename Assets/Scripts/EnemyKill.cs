using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    private GameObject Enemy;
    
    public Vector2 offset;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(Enemy);
            Destroy(gameObject);
            
        } 
    }

    private void Update()
    {
        transform.position = Enemy.transform.TransformPoint(offset);
    }   
    private void Awake()
    {
        Enemy = GameObject.Find("Enemy1");
        

    }
}
