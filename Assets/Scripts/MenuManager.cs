using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    void Awake()
    {
        ShowCompletedLevels();
    }


    void ShowCompletedLevels()
    {
        for (int i = 1; i < 26; i++)
        {
            if (PlayerPrefs.HasKey("Level " + i))
            {
                GameObject.Find("Button " + i).GetComponentInChildren<Text>().color = new Color(0.3f, 0.2f, 0);
                GameObject.Find("Button " + i).GetComponent<Image>().color = new Color(1, 1, 1);
            }
        }
    }
}