using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicMenuManagerScript : MonoBehaviour
{
    public void startButton()
    {
        Debug.Log("startButton");
        loadScene("Gameplay");
    }

    public void settingsButton()
    {
        Debug.Log("settingsButton");
        loadScene("Settings");
    }

    public void quitButton()
    {
        Debug.Log("quitButton");
        Application.Quit();
    }

    private void loadScene(string sceneName)
    {
        Debug.Log("Load Scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
