using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName = "Day2"; // Ensure this matches your scene name exactly

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
