using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    // Start is called before the first frame update

    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Setup(int score)
    {
        Debug.Log(1);
        gameObject.SetActive(true);
        pointsText.text = "SCORE: " + score.ToString();
    }
    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void MenuScreen()
    {
        Debug.Log("Main Menu");
        SceneManager.LoadScene("MainMenu");
    }
}