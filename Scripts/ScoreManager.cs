using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager ScoreManagerInstance;

    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI scoreText;


    private void Awake()
    {
        ScoreManagerInstance = this;
    }
  

public void AddScore()
{
        score++;
        scoreText.text = "Score: " + score;
}
}
