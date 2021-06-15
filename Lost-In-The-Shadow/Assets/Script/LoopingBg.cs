using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBg : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float loopingSpeed = 0;
    float offset;
    public Material mat;

    // Update is called once per frame
    void Update()
    {
    }
}
