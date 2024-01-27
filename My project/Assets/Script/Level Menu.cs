using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Xml.Serialization;

public class LevelMenu : MonoBehaviour
{
    public GameObject MenuLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("LevelMenu"))
        {
            MenuLevel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void NextLevel()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }
    public void RestartLevel()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
