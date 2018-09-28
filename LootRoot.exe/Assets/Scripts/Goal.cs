using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public Gamemanager2 gm;

    private void OnTriggerEnter(Collider other)
    {
        print("aaaaaaaaaaaaaa");
        if(other.transform.tag == "Player")
        {
            gm.NextLevel();
        }
    }
}
