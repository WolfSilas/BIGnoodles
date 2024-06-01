using TMPro;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int tokens;   
    public TextMeshProUGUI tokenText; 
                                      
    public GameObject shopGenerate;
    private LaptopInteraction laptopInteraction; // Reference to the LaptopInteraction script
    private GameObject shopCanvas; // Reference to the shop canvas
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        tokenText.text = "Tokens" + tokens.ToString();

        // UpdateEEPText();
        laptopInteraction = FindObjectOfType<LaptopInteraction>(); // Find the LaptopInteraction script in the scene
        shopCanvas = laptopInteraction.shopCanvas; // Get the shop canvas reference
    }

    public void AddTokens()
    {
        characterController = GetComponent<CharacterController>();

        
        tokens++;
        tokenText.text = "Tokens" + tokens.ToString();
        // CheckPurchaseable();
        
    }
}




  //  void UpdateEEPText()
  //  {
   //     tokenText.text = "Tokens: " + tokens.ToString();
   // }

 