using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public int tokens;   
    public TMP_Text tokenText;
    public ShopItemSo[] shopItemso;
    public GameObject[] shopPanelsGo;
    public ShopTemplate[] shopPanels;
   
   // public GameObject shopGenerate;
   /// private LaptopInteraction laptopInteraction; // Reference to the LaptopInteraction script
    ///private GameObject shopCanvas; // Reference to the shop canvas
    /// <summary>
    /// /private CharacterController characterController;
    /// </summary>

    void Start()
    {
        //    characterController = GetComponent<CharacterController>();
        for (int i = 0; i < shopPanelsGo.Length; i++) 
        shopPanelsGo[i].SetActive(true);
        tokenText.text = "Tokens" + tokens.ToString();
        LoadPannels();
        // UpdateEEPText();
     //   laptopInteraction = FindObjectOfType<LaptopInteraction>(); // Find the LaptopInteraction script in the scene
      //  shopCanvas = laptopInteraction.shopCanvas; // Get the shop canvas reference
    }

    public void AddTokens()
    {
      //  characterController = GetComponent<CharacterController>();

        
        tokens++;
        tokenText.text = "Tokens" + tokens.ToString();
        // CheckPurchaseable();
        
    }
    public void LoadPannels()
    {
        for(int i = 0; i < shopItemso.Length; i ++) 
        {
            shopPanels[1].titleTxt.text = shopItemso[i].title;
            shopPanels[1].descriptionTxt.text = shopItemso[i].description;
            shopPanels[1].costTxt.text = "Tokens" + shopItemso[i].baseCost.ToString();

        }
    }
}

  

  //  void UpdateEEPText()
  //  {
   //     tokenText.text = "Tokens: " + tokens.ToString();
   // }

 