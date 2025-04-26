using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager init;
    public Text score;
    public Text highScore;
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
