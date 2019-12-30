using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    

    public GameObject PowerUp;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Player"))
        {
            Instantiate(PowerUp);
            
        }
    }
    
}