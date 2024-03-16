using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float StartTime = 0f;
    [SerializeField] float CurrentTime = 10f;
    [SerializeField] TextMeshProUGUI countdownText;
    public Timer_test JeSuisDansUnAutreScript_Test;

    // Start is called before the first frame update
    void Start()
    {
        StartTime = CurrentTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer();

    }
    void timer()
    {
        CurrentTime -= 1 * Time.deltaTime;
        countdownText.text = CurrentTime.ToString("0");

        if (CurrentTime <= 0)
        {
            CurrentTime = 0;
            JeSuisDansUnAutreScript_Test.JeSuisDansUnAutreScript();
            EndGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {

            


        }
    }
    void EndGame()
    {

        Debug.Log("fin de la partie");

    }
}
