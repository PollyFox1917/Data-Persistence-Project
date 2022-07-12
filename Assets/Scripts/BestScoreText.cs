using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreText : MonoBehaviour
{
    private Text textScore;
    static int highscore;
   
    // Start is called before the first frame update

    public void CheckBestScore(int score)
    {
        if (score>PlayerPrefs.GetInt("highscore",0))
        {
            PlayerPrefs.SetInt("highscore",score);
            textScore.text = "Best " + PlayerPrefs.GetString("name", "user") + " score: "+ "Highscore: " + score.ToString();
        }
    }

    void Start()
    {
      
        highscore = PlayerPrefs.GetInt("highscore",0);
        textScore = GetComponent<Text>();
        textScore.text = "Best " + PlayerPrefs.GetString("name", "user") + " score: "+ "Highscore: " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
