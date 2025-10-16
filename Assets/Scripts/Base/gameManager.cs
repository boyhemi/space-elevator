using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class gameManager : MonoBehaviour
{
    public static gameManager init;

    public GameObject gameOverPanel;
    

    private void Awake() {
        if (init == null)
        {
            init = this;
        }
    }

    private void Start()
    {

    }

    public void retryGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
        StartCoroutine(ShowGameOverMenu());
    }


    IEnumerator ShowGameOverMenu()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("GameOverMenu");
        Time.timeScale = 1;
    }    
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }




    private void Update() {
        // initScore++;
        // score.text = "Score: " + initScore.ToString();
        // PlayerPrefs.SetInt("highscore", initScore);
    }
}
