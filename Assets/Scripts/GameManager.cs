using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Design Patterns
    // Singleton - Only one copy of this will ever exist
    public static GameManager instance;

    private int itemCollected = 1000;

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

    public void UpdateScore(int score)
    {
        itemCollected += score;
        Debug.Log("Current Score " + itemCollected);
    }
}
