using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    public float moveSpeed = -5f;

    Rigidbody2D rb;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        //rb.AddForce(transform.right * moveSpeed);
        rb.velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        
    }
    
}
