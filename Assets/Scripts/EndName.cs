using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndName : MonoBehaviour
{
    string playerName = NameTransfer.theName;
    public GameObject displayText;



    public void Start()
    {
        displayText.GetComponent<Text>().text = "Currently playing: " + playerName; 
    }
}
