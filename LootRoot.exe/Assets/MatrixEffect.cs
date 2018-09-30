using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MatrixEffect : MonoBehaviour
{
    public float minX;
    public float maxX;
    public GameObject[] prefab;


	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("Update2", 0, 0.01f);
	}

    // Update is called once per frame
    public void Update2()
    {
        
        GameObject prefabCopy = Instantiate<GameObject>(prefab[Random.Range(0,prefab.Length)]);

        prefabCopy.transform.position = new Vector2(Random.Range(minX, maxX), 8);
        prefabCopy.transform.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        float speed = Random.Range(-120, 120); 
        if (speed > -30 && speed < 0)
        {
            speed = -30;
        }
        if (speed < 30 && speed >= 0)
        {
            speed = 30;
        }
        prefabCopy.transform.GetComponent<Rotate>().rotateSpeed = speed;


        GameObject.Destroy(prefabCopy, 10f);

        
    }
}
