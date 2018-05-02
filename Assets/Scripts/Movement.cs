using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    public Vector3 getForce()
    {
        return new Vector3(
            Input.GetAxis("Horizontal"), 0.0f,
            Input.GetAxis("Vertical"));
    }
}

