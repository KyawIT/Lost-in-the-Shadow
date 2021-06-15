using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JumpMovement : MonoBehaviour
{
    public float jumpSpeed = 10f;
    private Rigidbody2D rigidBody2D;
    public Vector2 jump; 

    void Start()
    {
        // initzializing 
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            jump = new Vector2(0f, jumpSpeed);
            rigidBody2D.velocity += jump;
        }        
    }
}

