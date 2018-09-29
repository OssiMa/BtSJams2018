using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThePlayerMovement : MonoBehaviour {
    public float playerSpeed = 0.15f;


	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * playerSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * playerSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * playerSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * playerSpeed);
        }
    }

    public void KillPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
