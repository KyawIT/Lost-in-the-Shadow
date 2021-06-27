using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBg : MonoBehaviour
{
    private float len, startPos;
    public GameObject camera;
    public float parallaxEffect;

    private void Start()
    {
        startPos = transform.position.x; // The start position of our player for us 0 on x.
        len = GetComponent<SpriteRenderer>().bounds.size.x; // Gives out the sprite length.
    }

    private void FixedUpdate()
    {
        float temp = camera.transform.position.x * (1 - parallaxEffect);
        float distance = camera.transform.position.x * parallaxEffect; // distance value is set to how far we have moved from start pos.
        transform.position = new Vector3(startPos+distance, transform.position.y, transform.position.z);
        if (temp > startPos)
        {
            startPos += len;
        }
        else if (temp < startPos - len)
        {
            startPos -= len;
        }
    }
}
