using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreKeeper : MonoBehaviour
{
    static public int newScore = 0;
    public Text NewScore;
    public Text HighScore;


    void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    public void IncreaseScore() // clicking on + button increases score
    {
        newScore += 1;
        NewScore.text = newScore.ToString();
        Debug.Log(newScore);
        PlayerPrefs.SetInt("HighScore", newScore);
    }

    public void DecreaseScore(int) // clicking on - button decreases score
    {
        newScore -= 1;
        NewScore.text = newScore.ToString();
        Debug.Log(newScore);
        PlayerPrefs.SetInt("Highscore", newScore);

    }
    
}
