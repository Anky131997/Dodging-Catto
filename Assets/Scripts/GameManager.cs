using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    bool gameOver = false;
    int score = 0;

    public Text scoreText;
    public Text scoreShow;
    public GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
    }
   

    public void GameOver()
    {
        gameOver = true;

        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpwaning();

        gameOverPanel.SetActive(true);
        scoreShow.text = score.ToString();
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;

            scoreText.text = score.ToString();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
