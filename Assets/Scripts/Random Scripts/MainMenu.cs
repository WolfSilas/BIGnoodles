using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("New Prototype");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void MalteScene()
    {
        SceneManager.LoadScene("New Prototype");
    }
}