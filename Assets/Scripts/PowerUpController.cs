using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    private bool spawn = true;

    public GameObject PowerUp;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Player") && spawn)
        {
            Instantiate(PowerUp);
            spawn = false;
        }
    }
    
}