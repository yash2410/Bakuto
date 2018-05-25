using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalHighScore : MonoBehaviour {

    public Text highScoreText;
    public float highScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        highScore = PlayerPrefs.GetFloat("highScore", 0);
        highScoreText.text = Mathf.Round(highScore) + "";

	}
}
