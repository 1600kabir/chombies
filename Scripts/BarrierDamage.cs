using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierDamage : MonoBehaviour
{
    public int barrierHealth;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Zombie"))
        {
            barrierHealth--;
        }
        if (barrierHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
