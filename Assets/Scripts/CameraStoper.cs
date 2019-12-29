using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStoper : MonoBehaviour
{
    private ConstantForce2D cf;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        cf = GetComponent<ConstantForce2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Player.dead)
        {
            Destroy(cf);
            Destroy(rb);
        }
    }
}
