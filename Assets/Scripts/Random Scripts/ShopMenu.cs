using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopMenu : MonoBehaviour
{
    public GameObject ShopUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !LaptopInteraction.isShopMenuActive)
        {
            ToggleShopMenu();
        }
    }
    public void ToggleShopMenu()
    {
        if (ShopUI != null)
        {
            bool isPaused = !ShopUI.activeSelf;
            ShopUI.SetActive(isPaused);
            Time.timeScale = isPaused ? 0f : 1f; // Pause or resume the game accordingly

            // Lock or unlock the cursor based on pause state
            Cursor.lockState = isPaused ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = isPaused; // Show or hide the cursor based on pause state
        }
    }
    
    public void ResumeGame()
    {
        // Toggle the visibility of the pause menu canvas
        if (ShopUI != null)
        {
            ShopUI.SetActive(false); // Hide the pause menu canvas
            Time.timeScale = 1f; // Resume the game by setting time scale to 1

            // Lock the cursor again when the game resumes
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false; // Hide the cursor again
        }
    }

  

   
}