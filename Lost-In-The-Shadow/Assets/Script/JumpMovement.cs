using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JumpMovement : MonoBehaviour
{
    private float yMov;
    public float jumpForce;
    public Rigidbody2D rb2D;

    // Update is called once per frame
    void Update()
    {
        yMov = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //If yMov is 1 or the space key is pressed
        if (yMov == 1f || Input.GetKeyDown(KeyCode.Space))
        {
            // the velocity that effected the rigibody is equal to the 
            rb2D.velocity = Vector2.up * jumpForce;
        }
    }
}