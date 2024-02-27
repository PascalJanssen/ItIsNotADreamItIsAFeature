using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "Menu") Application.Quit();
            LoadMenu();
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }


    public void LoadLevel(string levelname)
    {
        SceneManager.LoadScene(levelname);
    }
}
