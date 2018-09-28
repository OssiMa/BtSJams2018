using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    float speed;
    public GameObject shooting;

    // Use this for initialization
    void Start()
    {
        speed = .1f;        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (gameObject.name == "UpBullet(Clone)")
        {
            transform.position += transform.up * speed;
        }
        else if (gameObject.name == "DownBullet(Clone)")
        {
            transform.position -= transform.up * speed;
        }
        else if (gameObject.name == "RightBullet(Clone)")
        {
            transform.position += transform.right * speed;
        }
        else if (gameObject.name == "LeftBullet(Clone)")
        {
            transform.position -= transform.right * speed;
        }


    }
}
