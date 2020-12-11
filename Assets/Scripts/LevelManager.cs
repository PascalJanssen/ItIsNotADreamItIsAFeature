using System.Collections;
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


    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }


    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
}
