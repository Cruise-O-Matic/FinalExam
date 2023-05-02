using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
   // public Text timeLimitText;
    public Text remainingTimeText;

    float timelimit = TimeSlider.seconds; //30.0f;
    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timelimit;

       // timeLimitText.text = "time limit: " + timelimit.ToString("F2");
        remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
    }


    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            remainingTimeText.text = "game over";
        }

    }
}