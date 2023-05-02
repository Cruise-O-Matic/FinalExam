using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsAdjuster : MonoBehaviour
{
    public Text pointsText;

    private int number = 0;

    private void Start()
    {
        UpdatepointsText();
    }

    public void IncreasePoints()
    {
        if (number >= 0)
        {
            number++;
            UpdatepointsText();
        }
    }

    public void DecreasePoints()
    {
        if (number > 0)
        {
            number--;
            UpdatepointsText();
        }
    }

    private void UpdatepointsText()
    {
        pointsText.text = number.ToString();
    }
}
