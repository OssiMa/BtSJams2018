using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour {
    public List<GameObject> doors = new List<GameObject>();
    public float hackingDistance;
    GameObject Player;
    public float hackingTime;
    float hackedTime;
    bool hacked = false;
    Color baseColor;
    Color endColor = Color.green;
    SpriteRenderer spriteRenderer;
    float T;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        baseColor = gameObject.GetComponent<SpriteRenderer>().color;
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    private void Update()
    {
        if (Player != null && !hacked)
        {

            if (Vector2.Distance(transform.position, Player.transform.position) < hackingDistance)
            {
                hackedTime += Time.deltaTime;
                T = Time.time;
                //Color.Lerp(baseColor, Color.green, Time.time*hackingTime);
               // GetComponent<SpriteRenderer>().material.color = Color.Lerp(baseColor, Color.green, T);
                spriteRenderer.color = Color.Lerp(baseColor, endColor, Mathf.PingPong(Time.time / hackingTime, 5.0f));

                if (hackedTime > hackingTime)
                {
                    hacked = true;
                    if (doors != null)
                    {
                        foreach (GameObject door in doors)
                        {
                            Destroy(door);
                        }
                        //gameObject.GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
            }
            else
            {
                hackedTime = 0;
                T = 0;
                gameObject.GetComponent<SpriteRenderer>().color = baseColor;

            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, hackingDistance);
    }
}
