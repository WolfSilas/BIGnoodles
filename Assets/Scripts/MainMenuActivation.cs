using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuCanvas;
    public GameObject helpPanel;
    public Text helpText;

    void Start()
    {
        // Ensure that the help panel is initially hidden
        if (helpPanel != null)
        {
            helpPanel.SetActive(false);
        }
    }

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

    public void ShowHelp()
    {
        // Toggle the visibility of the help panel
        if (helpPanel != null)
        {
            helpPanel.SetActive(!helpPanel.activeSelf);

            // Set sample instructions in the help text
            if (helpText != null)
            {
                if (helpPanel.activeSelf)
                {
                    helpText.text = "Sample Instructions:\n\n- Use WASD or arrow keys to move.\n- Press Spacebar to jump.\n- Press Escape to open this menu.";
                }
                else
                {
                    helpText.text = ""; // Clear the help text when hiding the panel
                }
            }
        }
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}