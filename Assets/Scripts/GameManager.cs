using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject endUIPanel;
    public GameObject winUIPanel;
    public TMP_Text endUIText;

    private int MAX_ITEMS = 5;

    // Design Patterns
    // Singleton - Only one copy of this will ever exist
    public static GameManager instance;

    private int itemCollected = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void UpdateScore()
    {
        itemCollected++;
        endUIText.text = "You've collected " + itemCollected + " / 5";

        if(itemCollected >= MAX_ITEMS)
        {
            winUIPanel.SetActive(true);
        }

        Debug.Log("Current Score " + itemCollected);
    }

    public void ShowEndUI()
    {    
        endUIPanel.SetActive(true);
    }

    public void HideEndUI()
    {
        endUIPanel.SetActive(false);
    }
}
