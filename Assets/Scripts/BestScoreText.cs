using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreText : MonoBehaviour
{
    private Text textScore;
    static int highscore;
    public static int score;
    // Start is called before the first frame update
    

    void Start()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("highscore",0);
        textScore = GetComponent<Text>();
        textScore.text = "Best " + PlayerPrefs.GetString("name", "user") + " score: "+ "Highscore: " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
        }

        score++;
    }
}
