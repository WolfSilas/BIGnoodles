using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
    // Maximum number of items in the level
    public int MaxItems = 4;

    // Text objects to display player health, collected items, and progress
    public Text HealthText;
    public Text ItemText;
    public Text ProgressText;

    // Private variables to track collected items and player health
    private int _itemsCollected = 0;
    private int _playerHP = 10;

    void Start()
    {
        // Initialize UI text with starting values
        ItemText.text = "Items Collected: " + _itemsCollected;
        HealthText.text = "Player Health: " + _playerHP;
    }

    // Property to get and set the number of collected items
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            // Update collected items count
            _itemsCollected = value;
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
