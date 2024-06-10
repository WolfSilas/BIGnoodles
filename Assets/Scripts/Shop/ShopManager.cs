using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public QInteracion Quest;       //
    public Quest nameQuest;
    public string questname;        //
    public string questdescription;
    public int tokens;
    public Text tokensUI;
    public TMP_Text tokenText;          //
    public ShopItemSo[] shopItemso;     //
    public GameObject[] shopPanelsGo;   //
    public ShopTemplate[] shopPanels;   //
    public Button[] myPurchaseBtn;
    public GameObject TvBox;
    public GameObject WashingBox;
    public GameObject TumbleBox;
    public GameObject SolarBox;
    public GameObject ShopUi;
    public GameObject TvTemplate;
    public GameObject WashTemplate;
    public GameObject TumbleTemplate;
    public GameObject SolarTemplate;
    public int QuestCounter = 0;
    public BedInteraction bedscript;

    void Start()
    {
        for (int i = 0; i < shopPanelsGo.Length; i++)           //
            shopPanelsGo[i].SetActive(true);                        //

        tokenText.text = "Tokens:" + tokens.ToString();
        tokensUI.text = "Tokens:" + tokens.ToString();//

        LoadPannels();                                          //
        CheckPurchasable();
        questdescription = nameQuest.description;
        questname = nameQuest.questName;
    }
  

    public void AddTokens()                                     //
    {


        tokens += 15;                                               //
        tokenText.text = "Tokens:" + tokens.ToString();
        tokensUI.text = "Tokens:" + tokens.ToString();

        //
        CheckPurchasable();
        
    }


    public void LoadPannels()                                                               //
    {
        for (int i = 0; i < shopItemso.Length; i++)                                         //
        {
            shopPanels[i].titleTxt.text = shopItemso[i].title;                              //
            shopPanels[i].descriptionTxt.text = shopItemso[i].description;                  //
            shopPanels[i].costTxt.text = "Tokens:" + shopItemso[i].baseCost.ToString();      //

        }
    }
   
    public void DeleteItemTv()
    {
        TvTemplate.SetActive(false);   
    }
    public void DeleteItemSolar()
    {
        SolarTemplate.SetActive(false);
    }
    public void DeleteItemTumble()
    {
        TumbleTemplate.SetActive(false);
    }
    public void DeleteItemWash()
    {
        WashTemplate.SetActive(false);
    }
    public void CheckPurchasable()
    {
        for (int i = 0; i < shopPanelsGo.Length; i++)
        {
            if (tokens >= shopItemso[i].baseCost)
                myPurchaseBtn[i].interactable = true;
            else
                myPurchaseBtn[i].interactable = false;
        }
    }

    public void PurchaseQuest()
    {
        if (QuestCounter == 0)
            Quest.Interact(questname, questdescription);
        QuestCounter++;
        
    }
    public void Purchaseitems(int btnNo)
    {
        if (tokens >= shopItemso[btnNo].baseCost)
        {
            tokens = tokens - shopItemso[btnNo].baseCost;
            tokenText.text = "Tokens:" + tokens.ToString();
            tokensUI.text = "Tokens:" + tokens.ToString();
            CheckPurchasable();
            PurchaseQuest();
            
        }
    }
    public void CloseShop()
    {
       ShopUi.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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

  

