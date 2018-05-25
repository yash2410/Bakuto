using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour {

    public Text finalhighScoreText;
    public float finalhighScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        finalhighScore = PlayerPrefs.GetFloat("highScore", 0);
        finalhighScoreText.text = " " + finalhighScore + "";

	}
}
