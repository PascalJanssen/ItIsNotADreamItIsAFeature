using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFunction : SwitchFunction
{
    protected override void OnMouseDown(){ }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Goal" && switchableObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Victory");
        }
    }
}