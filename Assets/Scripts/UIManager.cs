using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Play button is pushed
    public void NextLevelButtonPressed()
    {
        // SceneManager.LoadScene("Level1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Options button is pushed
    public void OptionsButtonPressed()
    {
        Debug.Log("Opened Options Menu");
    }

    // Quit button is pushed
    public void QuitButtonPressed()
    {
        Application.Quit(); 
    }

    public void MainMenuButtonPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
