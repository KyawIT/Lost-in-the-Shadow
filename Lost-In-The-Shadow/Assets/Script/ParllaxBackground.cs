using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParllaxBackground : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;

    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        cameraTransform.position += deltaMovement;

        lastCameraPosition = cameraTransform.position;
    }
}
