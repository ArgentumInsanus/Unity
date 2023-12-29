using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;
    public static int scoreCount;
    public static int hiscoreCount;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            hiscoreCount = PlayerPrefs.GetInt("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreCount > hiscoreCount)
        {
            hiscoreCount = scoreCount;
            PlayerPrefs.SetInt("HighScore", hiscoreCount);
        }
        scoreText.text = "Score: " + Mathf.RoundToInt(scoreCount);
        hiScoreText.text = "High-Score: " + hiscoreCount;
    }
}
