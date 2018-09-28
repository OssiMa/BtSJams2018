using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingEnemyAI : MonoBehaviour {
    GameObject Player;
    public float followDistance = 3;
    public float speed = 1;
    bool follow;

	// Use this for initialization
	void Start ()
    {
		Player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Player != null)
        {
            if (follow)
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), Player.transform.position, speed * Time.deltaTime);
            }
            if (Vector2.Distance(transform.position, Player.transform.position) < followDistance)
            {
                follow = true;
            }
            else
            {
                follow = false;
            }
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Destroy(collision.gameObject);
            print("ok");
            //GameOver
        }

    }


}
