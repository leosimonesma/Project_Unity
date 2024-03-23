using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AffichageScores : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject ScoreMenuUI;


    // Update is called once per frame
    void Update()
    {
        
    }
   public void Affichage_Scores()
    {
        ScoreMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SCN_MainMenu");
    }
}
