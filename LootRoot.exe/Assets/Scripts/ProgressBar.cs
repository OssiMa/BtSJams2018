using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour {

    Vector2 localScale;
    Collectible parent;

	// Use this for initialization
	void Start () {
        localScale = transform.localScale;
        Transform go = transform.parent;
        parent = go.GetComponent<Collectible>();
	}
	
	// Update is called once per frame
	void Update () {
        localScale.x = parent.progress/parent.hackAmount;
        transform.localScale = localScale;
	}
}
