using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    
    //Script universial para controle do score do game
    public int Score;
    public int CoinScore;
    public Text scoreText;
    public Text coinText;
    public float ScorePerSecond;
    public static GameController current;
    public bool PlayerIsAlive;

    void Start()
    {
        current = this;
        PlayerIsAlive = true;
    }

    float ScoreUpdated;
    void Update()
    {
        if(PlayerIsAlive)
        {
            ScoreUpdated += ScorePerSecond * Time.deltaTime;
            Score = (int)ScoreUpdated;

            //Atualizando elemento de texto da minha interface
            scoreText.text = Score.ToString("0000"); 
        }
    }

    public void AddScore(int value)
    {
        CoinScore += value;
        coinText.text = CoinScore.ToString("0000");
    }
}
