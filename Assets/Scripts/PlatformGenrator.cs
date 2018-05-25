using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenrator : MonoBehaviour {

    public GameObject[] Platform;
    public Transform genrationPoint;
    public float platormWidth;
    private int rand;

	// Use this for initialization
	void Start () {
        platormWidth = 30;
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x  < genrationPoint.position.x) {
            transform.position = new Vector3(transform.position.x+platormWidth,Random.Range(-15,15),transform.position.z);
            rand = Random.Range(0,5);

            Instantiate(Platform[rand], transform.position, transform.rotation);
        }	
	}
}
