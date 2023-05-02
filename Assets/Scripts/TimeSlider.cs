using UnityEngine;
using UnityEngine.UI;

public class TimeSlider : MonoBehaviour
{

    public Slider mySlider; // slider is set from 2 to 6 with start value of 4, same as speed in PlayerMovement
    public Text timerText;
    public static float seconds ;

    // Update is called once per frame
    void Update()
    {
        seconds = mySlider.value;
        timerText.text = ("Timer: " + seconds.ToString("f0")); 
    }
}

