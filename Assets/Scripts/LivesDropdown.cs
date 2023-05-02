using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDropdown : MonoBehaviour
{
    public Dropdown dropdown;
    public Text livesText;
    public static int theLives;

    private int selectedLives = 9;

    void Start()
    {
        dropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(dropdown); });
        livesText.text = "Select Number of Lives: " + selectedLives;
        
    }

    void DropdownValueChanged(Dropdown dropdown)
    {
        selectedLives = dropdown.value + 1;
        livesText.text = "Lives: " + selectedLives;
        theLives = selectedLives;
    }

    public int GetSelectedLives()
    {
        return selectedLives;
        
    }
}

