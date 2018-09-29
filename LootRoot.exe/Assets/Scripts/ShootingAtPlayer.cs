using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAtPlayer : MonoBehaviour {

    GameObject player;

    float speed;
    float deathTimer;

    public bool homing;

    Vector3 targetPos;

    // Use this for initialization
    void Start ()
    {
        if (homing)
        {
            speed = .08f;
        }
        else
        {
            speed = .06f;
        }

        player = GameObject.FindGameObjectWithTag("Player");

        deathTimer = 8;

        targetPos = player.transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (homing)
        {
            deathTimer -= .1f;

            if (deathTimer <= 0)
            {
                Destroy(gameObject);
            }
        }

        if(homing)
        {
            targetPos = player.transform.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);

        if (!homing)
        {
            if (transform.position == targetPos)
            {
                Destroy(gameObject);
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)      //Onko player trigger vai collision?
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
