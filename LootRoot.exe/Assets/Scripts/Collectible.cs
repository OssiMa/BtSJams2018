using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    public Gamemanager2 gm;
    float time;
    public float timeToPickup = 1;

    public float progress;
    public float hackAmount = 10;

    bool hacking = false;

    private void Start()
    {
        GameObject temp = GameObject.Find("Gamemanager2");
        gm = temp.GetComponent<Gamemanager2>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hacking = true;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        hacking = false;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Stop();
    }

    private void Update()
    {

        if (hacking == true)
        {
            if (Input.anyKeyDown)
            {
                progress += 1;
            }
        }

        if(progress >= hackAmount)
        {
            gm.Looted();
            Destroy(gameObject);
        }
    }
}
