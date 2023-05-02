using UnityEngine;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
        
    public static string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = theName + ", move slider to adjust play time, " +
            "use dropdown for number of desired lives, and click Next button to continue .";
    }

}
