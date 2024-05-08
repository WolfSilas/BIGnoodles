using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameBehavior : MonoBehaviour
{
    // Maximum number of items in the level
    public int MaxItems = 4;

    // Text objects to display player health, collected items, and progress

    public TMPro.TextMeshProUGUI HealthText;
    public TMPro.TextMeshProUGUI ItemText;
    public TMPro.TextMeshProUGUI ProgressText;
    public TMPro.TextMeshProUGUI sustainableValue;

    // Private variables to track collected items and player health
    public int _itemsCollected = 50;
    public int _playerHP = 80;

    void Start()
    {
        // Initialize UI text with starting values
        ItemText.text = "Sustainability: " + _itemsCollected;
        HealthText.text = "Energy Efficiency Points: " + _playerHP;
    }

    // Property to get and set the number of collected items
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            // Update collected items count
            _itemsCollected = value;
            sustainableValue.text = value.ToString();
            ItemText.text = "Items Collected: " + Items;

            // Check if all items have been collected
            if (_itemsCollected >= MaxItems)
            {
                // Update progress text when all items are collected
                ProgressText.text = "You've found all the items!";
            }
            else
            {
                // Update progress text with remaining items to collect
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) + " more to go!";
            }
        }
    }
// Property to get and set player health
    public int HP
    {
        get { return _playerHP; }
        set
        {
            // Update player health
            _playerHP = value;
            HealthText.text = "Player Health: " + HP;
            Debug.LogFormat("Lives: {0}", _playerHP);

            // Check for losing condition (if health reaches zero or below)
            if (_playerHP <= 0)
            {
                // Implement losing condition here (in this case, just log a message)
                Debug.Log("Game Over - Player has lost!");
            }
        }
    }
}