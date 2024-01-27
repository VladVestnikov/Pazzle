using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject settingsMenu;
    public GameObject levelMenu;

    public void Play() 
    {
        SceneManager.LoadScene(1);
    }
    public void Leveling()
    {
        menu.SetActive(false);
        settingsMenu.SetActive(false);
        levelMenu.SetActive(true);
    }
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
    public void Level3()
    {
        SceneManager.LoadScene(3);
    }
    public void Level4()
    {
        SceneManager.LoadScene(4);
    }
    public void Level5()
    {
        SceneManager.LoadScene(5);
    }
    public void Level6()
    {
        SceneManager.LoadScene(6);  
    }

    public void Level7()
    {
        SceneManager.LoadScene(7);
    }

    public void Level8()
    {
        SceneManager.LoadScene(8);
    }
    public void Level9()
    {
        SceneManager.LoadScene(9);
    }
    public void Level10()
    {
        SceneManager.LoadScene(10);
    }
    public void Level11()
    {
        SceneManager.LoadScene(11);
    }
    public void Level12()
    {
        SceneManager.LoadScene(12);
    }
    public void Level13()
    {
        SceneManager.LoadScene(13);
    }
    public void Level14()
    {
        SceneManager.LoadScene(14);
    }
    public void Level15()
    {
        SceneManager.LoadScene(15);
    }
    public void Level16()
    {
        SceneManager.LoadScene(16);
    }
    public void ExitLeveling()
    {
        menu.SetActive(true);
        settingsMenu.SetActive(false);
        levelMenu.SetActive(false);
    }
    public void Settings() 
    {
        menu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void ExitSettings() 
    {
        menu.SetActive(true);
        settingsMenu.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
