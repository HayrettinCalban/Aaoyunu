using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Windows;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject gameOverPanel;

    [SerializeField] private TMP_Text scoreText;
    public int score;
    private bool isGamePaused = false;

    public bool IsGamePaused { get => isGamePaused; set => isGamePaused = value; }

    private void Start()
    {
        instance = this;
        gameOverPanel.transform.localScale = Vector3.zero;
    }
    public void increaseScore()
    {
        score++;
        scoreText.text = score.ToString("0");
    }
    public void RestartGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        if(Time.timeScale==0)
        {
            gameOverPanel.transform.localScale = Vector3.one;
        }
    }
}
