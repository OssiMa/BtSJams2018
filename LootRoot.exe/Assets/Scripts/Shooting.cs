using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    float timer;
    const float reset = 2;
    public GameObject upBullet;
    public GameObject downBullet;
    public GameObject rightBullet;
    public GameObject leftBullet;
    public GameObject godBullet;
    public GameObject homingGodBullet;

    public enum Direction { up, down, left, right, god, homingGod };
    public Direction direction;

    GameObject spawnObject;

    // Use this for initialization
    void Start ()
    {
        timer = reset;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= .1f;
        
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
            }
            else if (direction == Direction.homingGod)
            {
                spawnObject = homingGodBullet;
            }

            Instantiate(spawnObject);
            spawnObject.transform.position = transform.position;
            timer = reset;
        }
	}
}
