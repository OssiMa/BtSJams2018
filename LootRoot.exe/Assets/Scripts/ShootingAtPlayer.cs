using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingAtPlayer : MonoBehaviour {

    GameObject player;

    public float speed;
    public float flyLength;

    public bool homing;
    public bool explode;

    Vector3 targetPos;

    public GameObject upBullet;
    public GameObject downBullet;
    public GameObject rightBullet;
    public GameObject leftBullet;

    bool search;

    Vector3 moveDirection;

    float distance;

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

        flyLength = 23;

        targetPos = player.transform.position;

        search = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (transform.position != targetPos && search == true)
            {
                if (homing)
                {
                    targetPos = player.transform.position;
                }

                transform.position = Vector3.MoveTowards(transform.position, (targetPos), speed);

                moveDirection = targetPos - transform.position;
                float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }

            distance = Vector2.Distance(targetPos, transform.position);

            if (distance <= 1f)
            {
                search = false;
            }

            if (search == false)
            {
                transform.rotation = transform.rotation;

                targetPos = transform.right;
                transform.position = Vector3.MoveTowards(transform.position, (targetPos), -speed);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)      
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
