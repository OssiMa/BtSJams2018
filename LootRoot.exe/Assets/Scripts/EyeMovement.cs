using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeMovement : MonoBehaviour {

    Vector3 playerPos;
    Vector3 myPos;
    GameObject player;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerPos = player.transform.position;
        myPos = transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        myPos.x += playerPos.x;
	}
}
