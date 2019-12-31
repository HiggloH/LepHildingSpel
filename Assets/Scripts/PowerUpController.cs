using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public bool spawn;

    public GameObject PowerUp;
    public Transform spawnHere;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Player") && spawn)
        {
            Instantiate(PowerUp, spawnHere.position, spawnHere.rotation);
            spawn = false;
        }
    }

    private void Awake()
    {
        spawn = true;
    }
}