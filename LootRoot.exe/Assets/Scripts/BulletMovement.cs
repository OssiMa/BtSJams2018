using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletMovement : MonoBehaviour {

    public float speed;
    public GameObject shooting;

    public float flyLength;

    // Use this for initialization
    void Start()
    {
        speed = .1f;
        flyLength = 16;
    }
	
	// Update is called once per frame
	void Update ()
    {
        flyLength -= .1f;

        if (flyLength <= 0)
        {
            Destroy(gameObject);
        }

        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
