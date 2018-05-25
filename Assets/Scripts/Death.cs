using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    public Rigidbody2D Runner;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Runner.IsTouchingLayers(LayerMask.GetMask("Thorn"))) {
            Destroy(Runner);
            SceneManager.LoadScene("EndScene");
        }	
	}
}
