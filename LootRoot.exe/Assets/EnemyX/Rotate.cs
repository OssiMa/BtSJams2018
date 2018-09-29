using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public enum axisList { none, x, y, z }
    public axisList rotateAxis;
    public float rotateSpeed;

    void Update()
    {
        if (rotateAxis == axisList.x)
        {
            transform.Rotate(2 * rotateSpeed * Time.deltaTime, 0, 0);
        }
        if (rotateAxis == axisList.y)
        {
            transform.Rotate(0, 2 * rotateSpeed * Time.deltaTime, 0);
        }
        if (rotateAxis == axisList.z)
        {
            transform.Rotate(0, 0, 2 * rotateSpeed * Time.deltaTime);
        }
    }
}