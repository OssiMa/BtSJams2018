using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tonttu : MonoBehaviour {

    GameObject[] remaining;
    float timer = 6;
	
	// Update is called once per frame
	void Update ()
    {
        CheckRemainingCollectibles();

        if (remaining.Length == 0)
        {
            Explode();
        }
    }

    void CheckRemainingCollectibles()
    {
        remaining = GameObject.FindGameObjectsWithTag("Loot");
    }

    void Explode()
    {


    }
}
