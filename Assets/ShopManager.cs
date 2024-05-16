using TMPro;
using UnityEngine;
using UnityEngine.Playables;

public class ShopManager : MonoBehaviour
{
    public int playerEEP = 50;  // Starting EEP
    public TextMeshProUGUI eepText; // Change the type to TextMeshProUGUI
    public GameObject[] furniturePrefabs;  // Assign prefabs here in the Inspector
    public Transform spawnPoint;

    private GameObject currentFurniture;
    private LaptopInteraction laptopInteraction; // Reference to the LaptopInteraction script
    private GameObject shopCanvas; // Reference to the shop canvas

    void Start()
    {
        UpdateEEPText();
        laptopInteraction = FindObjectOfType<LaptopInteraction>(); // Find the LaptopInteraction script in the scene
        shopCanvas = laptopInteraction.shopCanvas; // Get the shop canvas reference
    }

    public void BuyTV()
    {
        int tvIndex = 0; // Update this index based on the TV's position in the furniturePrefabs array
        int cost = furniturePrefabs[tvIndex].GetComponent<Furniture>().cost;

        if (playerEEP >= cost)
        {
            playerEEP -= cost;
            UpdateEEPText();

            // Call StartPlacingObject() to indicate that the player is placing an object
            laptopInteraction.StartPlacingObject();

            currentFurniture = Instantiate(furniturePrefabs[tvIndex], spawnPoint.position, Quaternion.identity);

            // Toggle off the shop canvas
            shopCanvas.SetActive(false);

            // Lock the cursor
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Debug.Log("Not enough EEP!");
        }
    }

    void UpdateEEPText()
    {
        eepText.text = "EEP: " + playerEEP.ToString();
    }

    void Update()
    {
        if (currentFurniture != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                PlaceFurniture();
            }
        }
    }

    void PlaceFurniture()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 position = hit.point;
            position.x = Mathf.Round(position.x);
            position.z = Mathf.Round(position.z);
            currentFurniture.transform.position = position;
            currentFurniture = null;

            // Call EndPlacingObject() to indicate that the player has finished placing the object
            laptopInteraction.EndPlacingObject();
        }

        // Lock the cursor even after placing the furniture
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}