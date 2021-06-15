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
        if (yMov == 1f || Input.GetKey(KeyCode.Space))
        {
            rb2D.AddForce(new Vector2(0 , jumpForce)*Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}

