using UnityEngine;
using TMPro;

public class LaptopInteraction : MonoBehaviour
{
    public GameObject shopCanvas;
    public float interactionDistance = 3f;
    private GameObject player;
    private bool isPlayerClose = false;
    private bool isPlacingObject = false; // Track if the player is currently placing an object

    // Assign the desired spawn point vector
    public Vector3 spawnPointPosition = new Vector3(-52, 35, 120);

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= interactionDistance)
        {
            isPlayerClose = true;
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform == transform)
                    {
                        ToggleShopCanvas();
                    }
                }
            }
        }
        else
        {
            isPlayerClose = false;
        }

        // Check if the Escape key is pressed to close the shop canvas
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (shopCanvas.activeSelf)
            {
                ToggleShopCanvas();
                if (isPlacingObject)
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                }
            }
        }
    }

    void ToggleShopCanvas()
    {
        shopCanvas.SetActive(!shopCanvas.activeSelf);
        if (!shopCanvas.activeSelf && !isPlacingObject)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    // You can also use this function to directly set the spawn point position
    public void SetSpawnPointPosition(Vector3 position)
    {
        spawnPointPosition = position;
    }

    // Call this function when placing an object starts
    public void StartPlacingObject()
    {
        isPlacingObject = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Call this function when placing an object ends
    public void EndPlacingObject()
    {
        isPlacingObject = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}