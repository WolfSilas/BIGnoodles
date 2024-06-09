using UnityEngine;
using UnityEngine.UI;

public class LaptopInteraction : MonoBehaviour
{
    public GameObject shopCanvas;
    public LaptopIn laptop; 
    public string questname;
    public Quest nameQuest;       //
                                  //
    public string questdescription;
    public static bool isShopMenuActive = false;
    public PlayerMove cameraMove;
    public Button CloseMenu;
    public QInteracion Quest;
    public int LaptopCounter = 0;
    public 
    void Update()
    {

       

        // Check if the Escape key is pressed to close the shop canvas(closing the shop menu)

       
    }
    public void Start()
    {
        Button btn = CloseMenu.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        questdescription = nameQuest.description;     //
        questname = nameQuest.questName;
    }
    void TaskOnClick()
    {
        if (LaptopCounter == 0)
            Quest.Interact(questname, questdescription);
        LaptopCounter++;
        laptop.QuestStart();
        if (shopCanvas.activeSelf)
        {
            ToggleShopCanvas();


        }
    }
    public void ToggleQuest()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {

            laptop.QuestStart();
            if (shopCanvas.activeSelf)
            {
                ToggleShopCanvas();


            }
        }
    }
    public void QuestStart()        //
    {
        Quest.Interact(questname, questdescription);
        Quest.gameObject.SetActive(true);
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
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
        }

    }
    

}
