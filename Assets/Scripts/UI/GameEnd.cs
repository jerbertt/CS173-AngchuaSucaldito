using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public Text pointsText;
    void Start()
    {
        Score();
    }
    public void QuitGame ()
    {
        Debug.Log("QUIT!"); // Since UNITY EDITOR DOESNT QUIT, it will print this instead so we can see it works
        Application.Quit();
    }

    public void MainMenuX()
    {
        Debug.Log("MainMenu!"); // Since UNITY EDITOR DOESNT QUIT, it will print this instead so we can see it works
        SceneManager.LoadScene(0);
    }

    public void Score()
    {
        pointsText.text = "SCORE: " + GameManager.Instance.score.ToString();
    }
}
