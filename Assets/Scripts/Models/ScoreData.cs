using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class ScoreData
{
    public static string HIGH_SCORE = "high_score";
    public static string CURRENT_SCORE = "current_score";

    public static void SetScore(string value, int score)
    {
        PlayerPrefs.SetInt(value, score);

    }

    public static int GetScore(string value)
    {
       return PlayerPrefs.GetInt(value);
    }

}
