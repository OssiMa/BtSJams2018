using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float PlayerSpeed = 0.15f;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * PlayerSpeed);
            //transform.position += Vector3.right * PlayerSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += Vector3.left * PlayerSpeed;
            transform.Translate(Vector2.left * PlayerSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.position += Vector3.down * PlayerSpeed;
            transform.Translate(Vector2.down * PlayerSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += Vector3.up * PlayerSpeed;
            transform.Translate(Vector2.up * PlayerSpeed);
        }
    }
}
