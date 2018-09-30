using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public Gamemanager2 gm;
    GameObject[] remaining;


    private void Start()
    {
        GameObject temp = GameObject.Find("Gamemanager2");
        gm = temp.GetComponent<Gamemanager2>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        CheckRemainingCollectibles();
        if(other.tag == "Player"&& remaining.Length == 0)
        {
            gm.NextLevel();
        }
    }

    void CheckRemainingCollectibles()
    {
        remaining = GameObject.FindGameObjectsWithTag("Loot");
    }
}
