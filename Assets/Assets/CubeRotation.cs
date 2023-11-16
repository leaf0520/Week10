using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    // Rotation speed for each axis
    public float rotationSpeedX = 30f;
    public float rotationSpeedY = 45f;
    public float rotationSpeedZ = 60f;

    void Update()
    {
        // Rotate the cube around the X, Y, and Z axes
        float rotationX = rotationSpeedX * Time.deltaTime;
        float rotationY = rotationSpeedY * Time.deltaTime;
        float rotationZ = rotationSpeedZ * Time.deltaTime;

        transform.Rotate(rotationX, rotationY, rotationZ);
    }
}
