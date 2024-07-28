using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    #region Singleton Pattern

    public static ScoreManager instance {  get; private set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }

        instance = this;
    }

    #endregion

    private int score = 0;

    public void ChangeScore(int score)
    {
        this.score += score;
    }

    public bool IsHighscore()
    {
        // Se score for maior que highscore, atualiza highscore e retorna true
        if (PlayerPrefs.GetInt("Highscore", 0) < score)
        {
            PlayerPrefs.SetInt("Highscore", score);
            return true;
        }

        // Se nao for, retorna false
        return false;
    }

    public int GetScore() { return score; }

    public void ResetScore()
    {
        score = 0;
    }
}
