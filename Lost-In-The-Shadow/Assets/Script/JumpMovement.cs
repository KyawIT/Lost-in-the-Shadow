using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JumpMovement : MonoBehaviour
{
    public float valueY;
    public float jumpForce;
    public Rigidbody2D rb2D;

    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //If yMov is 1 or the space key is pressed
        if (Input.GetKeyDown("space"))
        {
            // the velocity that effected the rigibody is equal to the 
            rb2D.velocity = Vector2.up * jumpForce;
        }
    }
}