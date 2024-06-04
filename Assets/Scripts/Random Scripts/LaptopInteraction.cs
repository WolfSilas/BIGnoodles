using UnityEngine;

public class LaptopInteraction : MonoBehaviour
{
    public GameObject shopCanvas;
    public LaptopIn laptop; 
    public static bool isShopMenuActive = false;
    public PlayerMove cameraMove;
    

    void Update()
    {

       

        // Check if the Escape key is pressed to close the shop canvas(closing the shop menu)
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
        isShopMenuActive = shopCanvas.activeSelf; 

        if (!isShopMenuActive)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }

}
