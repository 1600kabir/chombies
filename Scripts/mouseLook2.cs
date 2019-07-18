using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook2 : MonoBehaviour
{
    public float lookSensitivity = 2f, lookSmoothDamp = .5f;
    [HideInInspector]
    public float yRotation, xRotation;
    [HideInInspector]
    public float currentY, currentX;
    [HideInInspector]
    public float yRotationV, xRotationV;

    void LateUpdate()
    {
        yRotation += Input.GetAxis("Mouse X") * lookSensitivity;
        xRotation += Input.GetAxis("Mouse Y") * lookSensitivity;

        currentX = Mathf.SmoothDamp(currentX, xRotation, ref xRotationV, lookSmoothDamp);
        currentY = Mathf.SmoothDamp(currentY, yRotation, ref yRotationV, lookSmoothDamp);

        xRotation = Mathf.Clamp(xRotation, -80, 80);

        transform.rotation = Quaternion.Euler(-currentX, -currentY, 0);
    }
}