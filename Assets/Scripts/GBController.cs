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
}
