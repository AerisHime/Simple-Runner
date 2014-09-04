using UnityEngine;
using System.Collections;

public class ScoreSystem : MonoBehaviour {

    public GUIText scoreText;
    int scoreCount;
    bool isHighScore = false;
    int currentScore, highScore;

    // Use this for initialization
	void Start () {
        scoreCount = 0;
        ShowScore();
	}

    internal void AddScore()
    {
        scoreCount++;
    }

    internal void ShowScore()
    {
        scoreText.text = scoreCount.ToString();
    }

    internal void SaveScore()
    {
        PlayerPrefs.SetInt("CurrentScore", scoreCount);
        PlayerPrefs.Save();
    }

    internal void CalcHighScore()
    {
       // currentScore = PlayerPrefs.GetInt("CurrentScore");
        highScore = PlayerPrefs.GetInt("HighScore");
        if (highScore == null || scoreCount > highScore)
        {
            PlayerPrefs.SetInt("HighScore", scoreCount);
            isHighScore = true;
            PlayerPrefs.Save();
        }
        else
        {
            isHighScore = false;
        }

        ShowFinalScore(isHighScore);
    }

    internal void ShowFinalScore(bool newHighScore)
    {
        
        
        if (newHighScore)
        {
            scoreText.fontSize = 20;
            scoreText.text = "You have set a new High Score! It is " + scoreCount.ToString();
        }
        else
        {
            scoreText.fontSize = 20;
            scoreText.text = "Your highest score was " + highScore.ToString() + ", but your current score is " + scoreCount.ToString();
        }
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
