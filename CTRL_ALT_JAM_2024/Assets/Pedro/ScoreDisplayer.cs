using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI proUGUI;

    private void Start()
    {
        ScoreManager.instance.ResetScore();
    }

    public void ChangeScore(int score)
    {
        ScoreManager.instance.ChangeScore(score);
        proUGUI.text = ScoreManager.instance.GetScore().ToString();
    }
}
