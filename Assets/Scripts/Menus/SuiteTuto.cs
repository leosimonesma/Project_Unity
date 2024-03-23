using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuiteTuto : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject tuto_01UI;
    public GameObject tuto_02UI;
    public GameObject tuto_03UI;
    public GameObject tuto_04UI;


    // Update is called once per frame
    void Update()
    {

    }
    public void Tuto02()
    {
        tuto_02UI.SetActive(true);
        tuto_01UI.SetActive(false);

    }
    public void Tuto03()
    {
        tuto_03UI.SetActive(true);
        tuto_02UI.SetActive(false);
    }
    public void Tuto04()
    {
        tuto_04UI.SetActive(true);
        tuto_03UI.SetActive(false);
    }
    public void StartingGame()
    {
        SceneManager.LoadScene("Scène_Test_Leo");
    }
}
