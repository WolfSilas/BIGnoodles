using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public int tokens;                  //
    public TMP_Text tokenText;          //
    public ShopItemSo[] shopItemso;     //
    public GameObject[] shopPanelsGo;   //
    public ShopTemplate[] shopPanels;   //
    public Button[] myPurchaseBtn; 
    public GameObject TvBox;
    public GameObject WashingBox;
    public GameObject TumbleBox;
    public GameObject SolarBox;
    void Start()
    {
        for (int i = 0; i < shopPanelsGo.Length; i++)           //
        shopPanelsGo[i].SetActive(true);                        //
                
        tokenText.text = "Tokens" + tokens.ToString();          //

        LoadPannels();                                          //
        CheckPurchasable();
    }

    public void AddTokens()                                     //
    {

        
        tokens++;                                               //
        tokenText.text = "Tokens:" + tokens.ToString();          //
        CheckPurchasable() ;
    }

  
    public void LoadPannels()                                                               //
    {
        for(int i = 0; i < shopItemso.Length; i ++)                                         //
        {
            shopPanels[i].titleTxt.text = shopItemso[i].title;                              //
            shopPanels[i].descriptionTxt.text = shopItemso[i].description;                  //
            shopPanels[i].costTxt.text = "Tokens" + shopItemso[i].baseCost.ToString();      //

        }
    }


    public void CheckPurchasable ()
    {
        for (int i = 0; i < shopPanelsGo.Length ; i++ )
             {
            if (tokens >= shopItemso[i].baseCost)
                myPurchaseBtn[i].interactable = true;
            else
                myPurchaseBtn[i].interactable = false;
            }
     }


    public void Purchaseitems(int btnNo)
    {
        if (tokens >= shopItemso[btnNo].baseCost)
        {
            tokens = tokens - shopItemso[btnNo].baseCost;
            tokenText.text = "Tokens:" + tokens.ToString();
            CheckPurchasable();
        }
    }
    public void PurchaseTV()
    {
        TvBox.SetActive(true);
    }
    public void PurchaseWashingMachine()
    {
        WashingBox.SetActive(true);
    }
    public void PurchaseTumbleDryer()
    {
        TumbleBox.SetActive(true);
    }
    public void PurchaseSolarPanel()
    {
        SolarBox.SetActive(true);
    }
}

  

