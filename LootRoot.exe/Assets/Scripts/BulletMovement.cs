using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    float speed;
    public GameObject shooting;

    float deathTimer;

    // Use this for initialization
    void Start()
    {
        speed = .1f;
        deathTimer = 16;
    }
	
	// Update is called once per frame
	void Update ()
    {
        deathTimer -= .1f;

        if (deathTimer <= 0)
        {
            Destroy(gameObject);
        }

        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Bullet")
        {
            //Höhöö
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Move()
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
