using UnityEngine;

public class EndHouseTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.instance.ShowEndUI();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        GameManager.instance.HideEndUI();
    }
}
