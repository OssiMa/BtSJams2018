using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy : MonoBehaviour
{
    public Vector2 Velocity;

    private Vector2 _centre;

    private void Start()
    {
        Velocity = new Vector2(Random.Range(5, 10), Random.Range(5, 10));
        _centre = transform.position;
        StartCoroutine(ChangeDirection(Random.Range(1,3)));
    }

    private void Update()
    {

            _centre += Velocity * Time.deltaTime;

        transform.position = _centre;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<ThePlayerMovement>().KillPlayer();
        }
        else
        {
            Velocity = -Velocity;
        }
    }

    IEnumerator ChangeDirection(float random)
    {
        yield return new WaitForSeconds(random);
        Velocity = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
        if ((Velocity.x < 5 && Velocity.x > -5) && (Velocity.y < 5 && Velocity.y > -5))
        {
            int randomi = Random.Range(0, 2);
            int randomi2 = Random.Range(0, 2);
            switch(randomi)
            {
                case 0:
                    if (randomi2 == 0)
                    {
                        Velocity.x = Random.Range(5, 20);
                    }
                    else if(randomi2 == 1)
                    {
                        Velocity.x = Random.Range(-5, -20);
                    }
                    break;
                case 1:
                    if (randomi2 == 0)
                    {
                        Velocity.y = Random.Range(5, 20);
                    }
                    else if (randomi2 == 1)
                    {
                        Velocity.y = Random.Range(-5, -20);
                    }
                    break;
            }
        }
        StartCoroutine(ChangeDirection(Random.Range(1,3)));

    }
    


}