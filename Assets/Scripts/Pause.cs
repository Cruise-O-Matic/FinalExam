using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    

    private bool isPaused = false;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            pauseMenu.SetActive(isPaused);

            if (isPaused)
            {
                Time.timeScale = 0f;
               
            }
            else
            {
                Time.timeScale = 1f;
                
            }
        }
    }
      
    public void Continue()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
       
    }

    public void Load()
    {
        Debug.Log("Loaded something.");
    }

    public void Save()
    {
        Debug.Log(LivesDropdown.theLives.ToString() + " Lives");
        //Debug.Log(PointsAdjuster.pointsText.ToString() + " Points");
       // Debug.Log(LivesAdjuster.livesText.ToString());
    }

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
       
    }

    public void SaveAsJson()
    {
        // Implement save as JSON functionality here
        MyDataObject data = new MyDataObject();
        string jsonData = JsonUtility.ToJson(data);
        Debug.Log(jsonData);
    }

   //public void ToggleMusic(Toggle toggle)
   //{
   //    music.mute = !toggle.isOn;
   //}
}

[System.Serializable]
public class MyDataObject
{
    public int value;
    public string name;
}
