using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this whole script was made by Megan Ballard

public class Timer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 180f; 

    public Text countdown;

    void Start()
    {
      currentTime = startingTime;  
    }

    // Update is called once per frame
    void Update()
    {
      currentTime -= Time.deltaTime;

        currentTime = Mathf.Max(0, currentTime);

        string minutes = Mathf.Floor(currentTime / 60).ToString("00");
        string seconds = (currentTime % 60).ToString("00");

        countdown.text = $"{minutes}:{seconds}";

      if(currentTime <= 0) {
        currentTime = 0;
        EndGame();
      }
          
    }

    void EndGame()
    {
        Debug.Log("Game Over!");
        Application.Quit();
    }
}
