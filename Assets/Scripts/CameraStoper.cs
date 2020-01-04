using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStoper : MonoBehaviour
{
    public static bool move;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Player.dead)
        {
            Destroy(rb);
        }
        if (move)
        {
            // rb.velocity = new Vector2(3.5f, 0);
        }
    }
}
