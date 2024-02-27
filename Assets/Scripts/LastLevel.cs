using UnityEngine;

public class LastLevel : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i < 25; i++)
        {
            if (!PlayerPrefs.HasKey("Level " + i))
            {
                gameObject.SetActive(false);
                return;
            }
        }
    }
}
