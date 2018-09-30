using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tonttu : MonoBehaviour {

    GameObject[] remaining;
    float timer = 20;

    bool explode = true;

    public GameObject upBullet;
    public GameObject downBullet;
    public GameObject rightBullet;
    public GameObject leftBullet;

    SpriteRenderer tonttuS;

    private void Start()
    {
        tonttuS = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update ()
    {
        CheckRemainingCollectibles();

        if (remaining.Length == 0)
        {
            Explode();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }

    void CheckRemainingCollectibles()
    {
        remaining = GameObject.FindGameObjectsWithTag("Loot");
    }

    void Explode()
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

            explode = false;

            tonttuS.enabled = false;
        }

        timer -= .1f;

        if (timer <= 0)
        {
            SceneManager.LoadScene("Mainmenu");
        }
    }
}
