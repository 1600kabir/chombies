using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collision collision)
    {
        if (collision.collider.name == "Zombie")
        {
            Debug.Log("collision");
        }
    }
}
