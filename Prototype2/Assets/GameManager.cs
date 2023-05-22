using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI;
    [SerializeField] GameObject gameUI;
    [SerializeField] TextMeshProUGUI livesText;

    public static int currentLives;
    private int maxLives=3;

    private void Start()
    {
        currentLives = maxLives;
        Time.timeScale = 1;
        livesText.text = "Lives :" + currentLives.ToString();
    }

    private void Update()
    {
        Die();
    }
    void Die()
    {
        livesText.text = "Lives : " + currentLives.ToString();
        if (currentLives <= 0)
        {
            gameOverUI.SetActive(true);
            gameUI.SetActive(false);
            Time.timeScale = 0;
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
        gameUI.SetActive(true);


    }
    public void Menu()
    {
        SceneManager.LoadScene(0);

    }
    
}
