using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    float timer;
    public float shootRate = 2;
    public float godShootRate = 5;
    public float shootingDistance = 30;

    public GameObject upBullet;
    public GameObject downBullet;
    public GameObject rightBullet;
    public GameObject leftBullet;
    public GameObject godBullet;
    public GameObject homingGodBullet;
    public GameObject explodingGodBullet;

    public enum Direction { up, down, left, right, god, homingGod, explodingGod };
    public Direction direction;

    GameObject spawnObject;

    bool follow;

    GameObject player;

    public AudioSource audioS;

    // Use this for initialization
    void Start ()
    {
        timer = shootRate;
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (player != null)
        {
            if (Vector2.Distance(transform.position, player.transform.position) < shootingDistance)
            {
                follow = true;
            }
            else
            {
                follow = false;
            }

            timer -= .1f;

            if (follow == true)
            {
                if (timer <= 0)
                {
                    if (direction == Direction.up)
                    {
                        spawnObject = upBullet;
                    }
                    else if (direction == Direction.down)
                    {
                        spawnObject = downBullet;
                    }
                    else if (direction == Direction.left)
                    {
                        spawnObject = leftBullet;
                    }
                    else if (direction == Direction.right)
                    {
                        spawnObject = rightBullet;
                    }
                    else if (direction == Direction.god)
                    {
                        spawnObject = godBullet;
                        shootRate = godShootRate;
                    }
                    else if (direction == Direction.homingGod)
                    {
                        spawnObject = homingGodBullet;
                        shootRate = godShootRate;
                    }
                    else if (direction == Direction.explodingGod)
                    {
                        spawnObject = explodingGodBullet;
                        shootRate = godShootRate;
                    }

                    Instantiate(spawnObject);
                    spawnObject.transform.position = transform.position;
                    timer = shootRate;
                    audioS.Play();
                }
            }
        }
        }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, shootingDistance);
    }
}
