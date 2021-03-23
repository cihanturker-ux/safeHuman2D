using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public GameObject character;
    bool a = true;
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x < 0) 
        {
            character.transform.localScale = new Vector3(-1.8f, 1.7f,1.7f);
            if (a == true)
            {
                Rotate(true);
                a = false;
            }
           
        }
        else
        {
            if(movement.x > 0)
            {
                character.transform.localScale = new Vector3(1.8f, 1.7f, 1.7f);
                if (a == false)
                {
                    Rotate(false);
                    a = true;
                }
            }
        }

    }
    void Rotate(bool sol)
    {
            Quaternion theRotation = transform.localRotation;
        if (sol)
        {
            theRotation.z *= -1;
        }
        else
        {
            theRotation.z *= -1;
        }
            
            transform.localRotation = theRotation;
        
    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
