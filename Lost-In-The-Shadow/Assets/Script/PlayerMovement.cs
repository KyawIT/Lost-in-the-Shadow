using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float xVelocitySpeed, jumpForce;
    float movementInputX;
    private void Update()
    {
        // Input.GetAxisRaw("Horizontal") = Output is 1 if you press D or right ArrowKey
        // Input.GetAxisRaw("Horizontal") = Output is -1 if you press A or left ArrowKey
        movementInputX = Input.GetAxisRaw("Horizontal");
    }

    // With FixedUpdate frames are better caculated and we are messing with Physic
    private void FixedUpdate()
    {
        // All that above times movementX so it can move right or left. Example: speed = 100 * movementInputX = -1
        // 100 * -1 = -100 wihch means its going left
        Vector3 movement = new Vector3(movementInputX, 0 ,0);
        transform.position += movement * Time.deltaTime * xVelocitySpeed; 
    }
}
