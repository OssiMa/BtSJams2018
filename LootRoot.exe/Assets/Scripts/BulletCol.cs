using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCol : MonoBehaviour {

    float deathTimer;

    // Use this for initialization
    void Start ()
    {
        deathTimer = 7;
    }
	
	// Update is called once per frame
	void Update ()
    {
        deathTimer -= .1f;

        if (deathTimer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
