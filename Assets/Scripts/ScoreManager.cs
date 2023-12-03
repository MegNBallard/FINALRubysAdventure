using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;

    public Text winText;
    public Image uiBackground;

    public GameObject Gate; //Jan Wilkes

    int score = 0;

    private void Awake() {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + " out of 7 robots fixed";
    }

    public void AddPoint() {
        score += 1;
        scoreText.text = score.ToString() + " out of 7 robots fixed";

        if (score >= 7)
        {
            if (uiBackground != null)
            {
                uiBackground.gameObject.SetActive(true);
            }

            if (winText != null)
            {
                winText.gameObject.SetActive(true);
            }
        }
            // Gate script by Jan Wilkes 
        if (score >= 3)
        {
            if (Gate != null && score == 3)
            {
                DestroyGate();
            }
        }
    }
    private void DestroyGate()
    {
        Destroy(Gate); 
    }
    
}
