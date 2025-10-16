using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text highScore;


    public int initScore;
    public int initHighScore;

    // Start is called before the first frame update
    void Start()
    {
        initScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHighScore()
    {
        highScore.text = "High Score: " + ScoreData.GetScore(ScoreData.HIGH_SCORE);
    }

}
