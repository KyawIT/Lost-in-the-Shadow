using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrol: MonoBehaviour
{
    public float walkSpeed;
    public Rigidbody2D rigidBody;
    public BoxCollider2D bodyCollider;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        bodyCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (isFacingRight())
        {
            rigidBody.velocity = new Vector2(walkSpeed,0f);
        }
        else
        {
            rigidBody.velocity = new Vector2(-walkSpeed, 0f);

        }
    }
    private bool isFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(rigidBody.velocity.x)), transform.localScale.y);
    }
}
