using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerFunction : SwitchFunction
{
    public override void OnPointerDown(PointerEventData pointerEventData) { }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Goal" && switchableObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Victory");
        }
    }
}