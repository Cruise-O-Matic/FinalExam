using UnityEngine;
using UnityEngine.UI;

public class LivesAdjuster : MonoBehaviour
{
    public Text livesText;



    private int number = LivesDropdown.theLives;

    private void Start()
    {
        UpdatelivesText();
    }

    public void IncreaseLives()
    {
        if (number < 9)
        {
            number++;
            UpdatelivesText();
        }
    }

    public void DecreaseLives()
    {
        if (number > 0)
        {
            number--;
            UpdatelivesText();
        }
    }

    private void UpdatelivesText()
    {
        livesText.text = number.ToString();
    }
}