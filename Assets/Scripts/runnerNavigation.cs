using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class runnerNavigation : MonoBehaviour {

    public float runnerSpeed;
    public float runnerJump;

    public Rigidbody2D Runner;

    
    // Use this for initialization
    void Start()
    { 
        Runner = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Runner.IsTouchingLayers(LayerMask.GetMask("Speed")))
        {
            Debug.Log("Speed Changing");
            runnerSpeed = Random.Range(20,40);
            runnerJump = Random.Range(20, 30);
        }

        Runner.velocity = new Vector3(runnerSpeed,Runner.velocity.y, 0);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Runner.IsTouchingLayers(LayerMask.GetMask("Ground")) || Runner.IsTouchingLayers(LayerMask.GetMask("Speed")))
                Runner.velocity = new Vector3(Runner.velocity.x, runnerJump, 0);
        }

        if (transform.position.y < -50) {
            SceneManager.LoadScene("EndScene");
        }
    }


 
}
