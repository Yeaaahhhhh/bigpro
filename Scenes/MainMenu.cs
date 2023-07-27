using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // load the game scene
        SceneManager.LoadScene("GameScene");
    }

    public void OpenSettings()
    {
        // load the settings scene
        SceneManager.LoadScene("SettingsScene");
    }

    public void QuitGame()
    {
        // quit the game
        Application.Quit();
    }
}