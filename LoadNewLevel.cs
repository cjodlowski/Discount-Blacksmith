using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour
{
    public GameObject Creation;
    public Scene ThrowingScene;
    private string CurrentLevel;
    private String[] Levels = {"Bow", "Sword", "Scythe", "Nunchucks", "MorningStar"};
    private static System.Random Rand = new System.Random();


    public void Start()
    {
        CurrentLevel = SceneManager.GetActiveScene().name;
    }
    public void LoadNextLevel()
    {
        if (CurrentLevel == "Title Screen")
        {
            CurrentLevel = "Tutorial";
            Debug.Log(CurrentLevel);
            SceneManager.LoadScene(CurrentLevel);
            
        }
        else
        {
            LoadRandomScene();
        }
    }

    private void LoadRandomScene()
    {
        int ind = Rand.Next(0, Levels.Length);

        CurrentLevel = Levels[ind];
        Debug.Log(CurrentLevel);
        SceneManager.LoadScene(Levels[ind]);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(CurrentLevel);
    }
}
