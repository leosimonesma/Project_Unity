using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
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
