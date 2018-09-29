using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    public Gamemanager2 gm;
    float time;
    public float timeToPickup = 1;

    bool timer = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            time = Time.time + timeToPickup;
            timer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            timer = false;
        }
    }

    private void Update()
    {
        if (timer == true && Time.time >= time)
        {
            gm.Looted();
            Destroy(gameObject);
        }
    }
}
