using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    // Start is called before the first frame update

    
    int playerLife = LivesDropdown.theLives;
    public GameObject displayText;
   
    

    void Start()
    {
        
        displayText.GetComponent<Text>().text = (LivesDropdown.theLives.ToString());
        Debug.Log("Selected Lives: " + LivesDropdown.theLives.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
