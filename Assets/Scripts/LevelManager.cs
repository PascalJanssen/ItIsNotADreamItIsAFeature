﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
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
