using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score=0;
    private int gameSpeedScore=0;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        
        scoreText.text = score.ToString();
    }
    private void Update()
    {
        
    }
    public void AddScore(int scoreAmount)
    {
        score += scoreAmount;
        scoreText.text = score.ToString();
    }
    public void GameSpeedControl(int scoreAmount)
    {
        gameSpeedScore += scoreAmount;
        if (gameSpeedScore >= 50)
        {
            AnimalSpawner.spawnInterval -= 0.10f;
            gameSpeedScore = 0;
        }
        
        
    }
}
