﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GunPosition : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    void Update() {
        transform.position = new Vector3(x, y, z);
    }
}
