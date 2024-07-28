using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplayer : MonoBehaviour
{
    public static ScoreDisplayer instance;

    [SerializeField] private TextMeshProUGUI proUGUI;


    private void Awake()
    {
        instance = this;
    }

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
