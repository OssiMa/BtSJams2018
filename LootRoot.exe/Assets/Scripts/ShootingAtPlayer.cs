using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAtPlayer : MonoBehaviour {

    GameObject player;

    float speed;
    float deathTimer;

    public bool homing;
    public bool explode;

    Vector3 targetPos;

    public GameObject upBullet;
    public GameObject downBullet;
    public GameObject rightBullet;
    public GameObject leftBullet;

    // Use this for initialization
    void Start ()
    {
        if (homing)
        {
            speed = 0.16f;
        }
        else
        {
            speed = 0.4f;
        }

        player = GameObject.FindGameObjectWithTag("Player");

        deathTimer = 23;

        targetPos = player.transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (player != null)
        {
            if (homing)
            {
                targetPos = player.transform.position;
            }

            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);

            if (!homing)
            {
                if (transform.position == targetPos)
                {
                    MyEnd();
                }
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)      //Onko player trigger vai collision?
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            MyEnd();
        }
        else if (collision.gameObject.tag == "Bullet")
        {
            //Höhöö
        }
        else
        {
            MyEnd();
        }
    }

    void MyEnd()
    {
        if (explode == true)
        {
            Instantiate(upBullet);
            Instantiate(downBullet);
            Instantiate(rightBullet);
            Instantiate(leftBullet);

            upBullet.transform.position = transform.position;
            downBullet.transform.position = transform.position;
            leftBullet.transform.position = transform.position;
            rightBullet.transform.position = transform.position;
        }

        Destroy(gameObject);
    }
}
