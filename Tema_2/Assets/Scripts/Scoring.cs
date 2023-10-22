using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class Scoring : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI printedScoreText;
    public int totalScore = 0;
    public int maxScore = 5;
    public GameObject scoring;
    public GameObject winningText;
    void Start()
    {
        totalScore = 0;
        winningText.SetActive(false);

    }
    public void AddToScore(int newScore)
    {
        // totalScore += Mathf.RoundToInt(score);
        totalScore += newScore;
        //UpdateScore();
    }

    public void UpdateScore()
    {
        printedScoreText.text = "Score: 0" + totalScore;
    }
    void Update()
    {
        UpdateScore();
        if (totalScore == maxScore)
        {
            winningText.SetActive(true);
        }
    }
}