using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreChecker : MonoBehaviour
{
    [SerializeField] private GameObject newHighscoreText;
    [SerializeField] private TextMeshProUGUI highscoreText;
    [SerializeField] private TextMeshProUGUI lastScoreText;

    private void Start()
    {
        newHighscoreText.SetActive(ScoreManager.instance.IsHighscore());

        highscoreText.text = "YOUR HIGHSCORE: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
        lastScoreText.text = "SCORE: " + ScoreManager.instance.GetScore().ToString();
    }
}
