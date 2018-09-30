using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlyMovingEnemy : MonoBehaviour
{
   // public float floatHeight = 1f;
    //public float liftForce = 1f;
    //public float damping = 2f;
   // public Rigidbody2D rb2D;
    public float distance;

    public float rotationSpeed = 1f;
    public float movementSpeed = 1f;
    public float rotationTime = 0.5f;


    public Vector3 direction;
    public float speed = 20f;
    public float minDist = 0.5f;
    public float maxDist = 1f;

    float MovementTimer = 15f;

    public float MovementDirection = 0;
    GameObject CollisionTarget;

    private void Start()
    {
        Invoke("ChangeRotation", rotationTime);
        
        
        //  rb2D = GetComponent<Rigidbody2D>();
    }

    void ChangeRotation()
    {
        if (Random.value > 0.5f)
        {
            rotationSpeed = -rotationSpeed;
        }

        Invoke("ChangeRotation", rotationTime);
    }

    void Update()
    {

        transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
        transform.position += transform.right * movementSpeed * Time.deltaTime;

        //print(MovementTimer);


    //    if (CollisionTarget == null)
    //    {

    //        transform.Translate(Vector2.up * speed * Time.deltaTime);
    //    }
    //    else Turn();

    //    if (MovementTimer <= 0)
    //    {
    //        Quaternion rotation = transform.rotation;
    //        transform.Rotate(Vector3.forward, Random.Range(0, 360));
    //        MovementTimer = 9f;
    //    }
    }

    //private void FixedUpdate()
    //{
    //    RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, 100f);

    //    //Debug.DrawLine(transform.position, transform.position + transform.right * 20f, Color.white);

    //    if (hit.collider != null)
    //    {
    //        //distance = Mathf.Abs(hit.point.y - transform.position.y);
    //        Debug.DrawLine(transform.position, hit.point, Color.white);
    //        distance = hit.distance;
    //        //float heightError = floatHeight - distance;
    //       // float force = liftForce * heightError - rb2D.velocity.y * damping;
    //        //rb2D.AddForce(Vector3.up * force);
    //        Debug.Log("A HIT!");

    //        if (distance <= 2f)
    //        {
    //            Turn();
    //        }
    //        else
    //        {
    //            Move();
    //        }

    //    }



    //    //transform.position += direction * speed * Time.deltaTime;
    //    //MovementTimer -= 0.1f;



    //}


    //public void Awake()
    //{
    //    Quaternion rotation = transform.rotation;
    //    transform.Rotate(Vector3.forward, Random.Range(0, 360));
    //    transform.Translate(transform.up * Random.Range(minDist, maxDist) * speed);


    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{

    //    if (collision.gameObject.tag == "wall")
    //    {
    //        Debug.Log("WALL HIT");
    //        CollisionTarget = collision.gameObject;
    //    }

    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Destroy(collision.gameObject);
    //        //GameOver
    //    }
    //}

    ////private void OnCollisionExit2D(Collision2D collision)
    ////{
    ////    Debug.Log("NO MORE WALL");
    ////    CollisionTarget = null;
    ////}

    //private void Move()
    //{
    //    transform.Translate(Vector2.right * speed * Time.deltaTime);
    //}

    //private void Turn()
    //{
    //    Debug.Log("TARGET");
    //    //transform.Rotate(new Vector3(0, 0, Time.deltaTime * 10f));
    //    //transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(-50f, 50f));
    //    //transform.rotation = 
    //    //transform.Translate(Vector2.up * speed * Time.deltaTime);
    //}

    

}









