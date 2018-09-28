using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAtPlayer : MonoBehaviour {

    GameObject player;
    float speed;

	// Use this for initialization
	void Start ()
    {
        speed = .1f;
        player = GameObject.FindGameObjectWithTag("Player");

    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
	}
}
