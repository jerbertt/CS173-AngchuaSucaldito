using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Control : MonoBehaviour
{
    public Text scoreText;
    public Text timeText;
    public static float time = 0;
    public static int score = 0;
    public GameOverScreen GameOverScreen;
    // Start is called before the first frame update
    
    void Start()
    {
        time = 0;
    }
    void Update()
    {
        time += Time.deltaTime;
        
        if(time >= 60)
        {
            time = 60.00f;
            SceneManager.LoadScene(2);
            return;
        }

        scoreText.text = "SCORE: " + GameManager.Instance.score.ToString();
        timeText.text = "TIME: " + time.ToString("F2");
        
    
    }

    public static void AddPoint()
    {
        GameManager.Instance.score++;
    }
    public static void MinusPoint()
    {
        GameManager.Instance.score--;
    }

    public void QuitGameIn ()
    {
        Debug.Log("QUIT!"); 
        Application.Quit();
    }

    public void MenuScreenIn ()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("MainMenu");
    }
}

