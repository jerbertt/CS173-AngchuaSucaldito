using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text pointsText;
    public void PlayGame()
    {
        Debug.Log("Click");
        GameManager.Instance.score=0;
        SceneManager.LoadScene("Game Scene");
        //Score();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!"); // Since UNITY EDITOR DOESNT QUIT, it will print this instead so we can see it works
        Application.Quit();
    }
}
