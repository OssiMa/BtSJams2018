using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyAI : MonoBehaviour {

    // Use this for initialization
    public Vector2 Point1;
    public Vector2 Point2;
    bool GoToPoint2;
    public float Speed = 1;
    public float GizmoPointSize = 0.2f;

    void Start ()
    {
        gameObject.transform.position = Point1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (GoToPoint2)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), Point2, Speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), Point1, Speed * Time.deltaTime);
        }
        if (transform.position.y == Point1.y && transform.position.x == Point1.x)
        {
            GoToPoint2 = true;
        }
        else if (transform.position.y == Point2.y && transform.position.x == Point2.x)
        {
            GoToPoint2 = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<ThePlayerMovement>().KillPlayer();
        }
        else
        {
            if (GoToPoint2)
            {
                GoToPoint2 = false;
            }
            else
            {
                GoToPoint2 = true;
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(Point1, GizmoPointSize);
        Gizmos.DrawSphere(Point2, GizmoPointSize);
    }
}
