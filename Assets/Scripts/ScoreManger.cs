using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour {

    public Text scoreText;
    public Text highscoreText;

    public float score;
    public float highScore;
    public float scoreSecond;

    public bool Increasing;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Increasing)
        {
            score += scoreSecond * Time.deltaTime;
        }
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("highScore", highScore);
        }
        Debug.Log("ScoreManager");
        scoreText.text = "Score : " + Mathf.Round(score);
        highscoreText.text = "High Score :" + Mathf.Round(highScore);
    }
}

