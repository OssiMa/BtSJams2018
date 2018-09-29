using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour {
    public List<GameObject> doors = new List<GameObject>();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            if (doors != null)
            {
                foreach(GameObject door in doors)
                {
                    Destroy(door);
                }
                gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            }
        }
    }
}
