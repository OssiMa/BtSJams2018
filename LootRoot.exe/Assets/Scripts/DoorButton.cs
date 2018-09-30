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
    AudioSource audioS;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        baseColor = gameObject.GetComponent<SpriteRenderer>().color;
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioS = GetComponent<AudioSource>();
        
    }

    private void Update()
    {
        if (Player != null && !hacked)
        {
            //print(Vector2.Distance(transform.position, Player.transform.position));
            if (Vector2.Distance(transform.position, Player.transform.position) < hackingDistance)
            {

                hackedTime += Time.deltaTime;
                spriteRenderer.color = Color.Lerp(baseColor, endColor, Mathf.PingPong(hackedTime / hackingTime, 5.0f));

                if (hackedTime > hackingTime)
                {
                    hacked = true;
                    if (doors != null)
                    {
                        foreach (GameObject door in doors)
                        {
                            Destroy(door);
                        }
                        audioS.Play();
                    }
                }
            }
            else
            {
                hackedTime = 0;
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
