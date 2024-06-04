using UnityEngine;

public class LaptopInteraction : MonoBehaviour
{
    public GameObject shopCanvas;
    public float interactionDistance = 3f;
    public LaptopIn laptop; //
    public static bool isShopMenuActive = false;
   
    

    void Update()
    {

       

        // Check if the Escape key is pressed to close the shop canvas
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            laptop.QuestStart(); 
            if (shopCanvas.activeSelf)
            {
                ToggleShopCanvas();
                
            }
        }
    }

    void ToggleShopCanvas()
    {
        shopCanvas.SetActive(!shopCanvas.activeSelf);
        isShopMenuActive = shopCanvas.activeSelf; // Update the static flag

        if (!shopCanvas.activeSelf) 
        {
            Cursor.lockState= CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    
}
