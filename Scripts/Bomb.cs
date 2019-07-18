using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camera;
    [HideInInspector]
    float targetXRotation, targetYRotation;
    [HideInInspector]
    float targetXRotationV, targetYRotationV;
    public GameObject shell;
    public Transform shellSpawnPos, bulletSpawnPos;
    public float rotateSpeed = .3f, holdHeight = -.5f, holdSide = .5f;

    void Update()
    {
        shoot();

        targetXRotation = Mathf.SmoothDamp(targetXRotation, FindObjectOfType<MouseLook>().xRotation, ref targetXRotationV, rotateSpeed);

        transform.position = camera.transform.position + Quaternion.Euler(0, targetYRotationV, 0) * new Vector3(holdSide, holdHeight, 0);

        float clampedX = Mathf.Clamp(targetXRotation, -70, 80);
        transform.rotation = Quaternion.Euler(-clampedX, targetYRotation, rotateSpeed);
    }

    void shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
        else if (Input.GetButton("Fire1"))
        {
            Fire();
        }
    }
    void Fire()
    {
        GameObject shellCopy = Instantiate<GameObject>(shell, shellSpawnPos.position, Quaternion.Euler(0, targetYRotationV, 0)) as GameObject;
        RaycastHit variable;
        bool status = Physics.Raycast(bulletSpawnPos.position, bulletSpawnPos.forward, out variable, 100);
    }
}
