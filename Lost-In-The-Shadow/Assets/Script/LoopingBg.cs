using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBg : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 lastCameraPosi;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosi = cameraTransform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosi;
        float parallaxEffectMultiplier = 0.0f;
        transform.position += deltaMovement* parallaxEffectMultiplier;
        lastCameraPosi = cameraTransform.position;
    }
}
