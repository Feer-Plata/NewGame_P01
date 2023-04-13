using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    //Atributos
    public static float score = 0f;
    public const string highScore = "HighScore";
    public TMP_Text scoreTxt;
    private void Start()
    {
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = score.ToString();
    }
    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(Score.highScore, 0);
        if (Score.score > currentHighScore)
        {
            PlayerPrefs.SetInt(Score.highScore, Mathf.FloorToInt(Score.score));
        }
    }
}
