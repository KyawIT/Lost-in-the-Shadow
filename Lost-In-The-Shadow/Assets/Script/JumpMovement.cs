using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isGrounded = true;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        bool playerJump = Input.GetButtonDown("Jump");
        bool isGrounded = IsGrounded();

        if (playerJump && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
    private bool IsGrounded()
    {
       Physics2D.
    }
}

