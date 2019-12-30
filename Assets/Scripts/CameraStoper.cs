using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStoper : MonoBehaviour
{
    
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

        rb.velocity = new Vector2 (2, 0);
    }
}
