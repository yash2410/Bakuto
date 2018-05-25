using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadMovement : MonoBehaviour {

    public Rigidbody2D thornRunner;

    private float initialX;
    private bool dir;
	// Use this for initialization
	void Start () {
        dir = true;
        initialX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x - initialX == 0)
        {
            dir = true;
        }
        else if (transform.position.x - initialX == 30)
        {
            dir = false;
        }
        else {
            Debug.Log("Inbetween");
        }
        if (dir) {
            thornRunner.velocity = new Vector3(10, transform.position.y, 0);
        }
        else{
            thornRunner.velocity = new Vector3(-10, transform.position.y, 0);
        }
        
		
	}
}
