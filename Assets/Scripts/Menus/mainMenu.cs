using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;


    private void Awake()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
    }
    public void ButtonPlay()
    {
        SceneManager.LoadScene("SCN_InGame");
    }

    public void QuitGame()
    {
        Debug.Log("Jeu quitté");
        Application.Quit();
    }
}
