using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class gameManager : MonoBehaviour
{
    public static gameManager init;
    public TMP_Text score;
    public TMP_Text highScore;

    public GameObject gameOverPanel;
    
    public int initScore;
    public int initHighScore;


    private void Awake() {
        if (init == null)
        {
            init = this;
        }
    }

    private void Start()
    {
        initScore = 0;
    }

    public void retryGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        StartCoroutine(ShowGameOverMenu());
    }


    IEnumerator ShowGameOverMenu()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("GameOverMenu");
    }    
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SetHighScore()
    {
        highScore.text = "High Score: " + PlayerPrefs.GetInt("highscore").ToString();
    }



    private void Update() {
        initScore++;
        // score.text = "Score: " + initScore.ToString();
        PlayerPrefs.SetInt("highscore", initScore);
    }
}
