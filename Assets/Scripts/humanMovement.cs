using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanMovement : MonoBehaviour
{
    public float humanMoveSpeed = 5f;
    Rigidbody2D rigb;
    void Start()
    {
        rigb = transform.GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        
        rigb.velocity = new Vector2(humanMoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        
    }
}
