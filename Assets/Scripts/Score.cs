using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    ////Atributos
    //public static float score = 0f;
    //public const string highScore = "HighScore";

    //public TMP_Text scoreTxt;
    //private void Start()
    //{
    //    score = 0;
    //}
    //// Update is called once per frame
    //void Update()
    //{
    //    score += Time.deltaTime;
    //    scoreTxt.text = score.ToString();
    //}
    //private void OnDestroy()
    //{
    //    int currentHighScore = PlayerPrefs.GetInt(Score.highScore, 0);
    //    if (Score.score > currentHighScore)
    //    {
    //        PlayerPrefs.SetInt(Score.highScore, Mathf.FloorToInt(Score.score));
    //    }
    //}
    public class ScoreTxt : MonoBehaviour
    {
        //Atributos
        public Text score;
        private void Update()
        {
            score.text = "Score: " + Scoring.score;
        }
    }

    public class Scoring : MonoBehaviour
    {
        //Atributos
        public static int score = 0;
    }
}
