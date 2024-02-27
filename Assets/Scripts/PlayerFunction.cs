using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerFunction : SwitchFunction
{
    private void Awake()
    {
        SwitchManager.player = transform.parent.GetComponent<SwitchableObject>();
    }

    public override void OnPointerDown(PointerEventData pointerEventData) { }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Goal" && switchableObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("Level " + SceneManager.GetActiveScene().name.Substring(4), 1);
            SceneManager.LoadScene("Victory");
        }
    }
}