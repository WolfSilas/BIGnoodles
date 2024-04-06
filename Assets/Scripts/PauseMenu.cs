using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuCanvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        if (pauseMenuCanvas != null)
        {
            bool isPaused = !pauseMenuCanvas.activeSelf;
            pauseMenuCanvas.SetActive(isPaused);
            Time.timeScale = isPaused ? 0f : 1f; // Pause or resume the game accordingly
        }
    }

    public void ResumeGame()
    {
        // Toggle the visibility of the pause menu canvas
        if (pauseMenuCanvas != null)
        {
            pauseMenuCanvas.SetActive(false); // Hide the pause menu canvas
            Time.timeScale = 1f; // Resume the game by setting time scale to 1
        }
    }

    public void ReturnToMainMenu()
    {
        // Hide the pause menu if it's active
        if (pauseMenuCanvas != null && pauseMenuCanvas.activeSelf)
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f; // Ensure the game resumes if the pause menu was active
        }

        // Return to the main menu
        SceneManager.LoadScene("MainMenu");
    }

    public void ShowHelp()
    {
        // You can display help instructions here or navigate to another scene with detailed instructions
        Debug.Log("Help: Use WASD to walk."); // Placeholder for displaying help
    }
}