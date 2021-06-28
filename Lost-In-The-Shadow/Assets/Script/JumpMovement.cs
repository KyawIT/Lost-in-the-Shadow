using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JumpMovement : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rb2D;
    float upValue;

    private void Update()
    {
        upValue = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        //If yMov is 1 or the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space) || upValue == 1)
        {
            // the velocity that effected the rigibody is equal to the 
            rb2D.velocity = Vector2.up * jumpForce;
        }
    }
}