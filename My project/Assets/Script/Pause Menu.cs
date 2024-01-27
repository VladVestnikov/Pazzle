using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
   public GameObject PausePanel;

    public void pauseBattonMenu() 
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void continuePlay() 
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void restartPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void menuButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
