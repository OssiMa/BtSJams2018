using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingEnemyAI : MonoBehaviour {
    public Vector3 minSize;
    public Vector3 maxSize;
    bool scaleDirectionUp = true;
    public float growSpeed = 1;
    public float changeTime;
    float T;
    private void Start()
    {
        transform.localScale = minSize;
    }
    // Update is called once per frame
    void Update ()
    {

        T += Time.deltaTime;
        if (scaleDirectionUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, maxSize, growSpeed * Time.deltaTime);
        }
        else if(!scaleDirectionUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, minSize, growSpeed * Time.deltaTime);
        }
        if (T > changeTime)
        {
            T = 0;
            if(scaleDirectionUp)
            {
                scaleDirectionUp = false;
            }
            else if (!scaleDirectionUp)
            {
                scaleDirectionUp = true;
            }
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
            T = 0;
            if (scaleDirectionUp)
            {
                scaleDirectionUp = false;
            }
            else if (!scaleDirectionUp)
            {
                scaleDirectionUp = true;
            }
        }
    }
}
