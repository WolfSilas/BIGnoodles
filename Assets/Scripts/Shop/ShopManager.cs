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
   

    void Start()
    {
        for (int i = 0; i < shopPanelsGo.Length; i++)           //
        shopPanelsGo[i].SetActive(true);                        //
                
        tokenText.text = "Tokens" + tokens.ToString();          //

        LoadPannels();                                          //

    }

    public void AddTokens()                                     //
    {

        
        tokens++;                                               //
        tokenText.text = "Tokens" + tokens.ToString();          //
        
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
}

  

