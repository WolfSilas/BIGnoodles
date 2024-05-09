using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] SustainabilityBar sustainabilityBar;

    // Start is called before the first frame update
    void Start()
    {
        // Get the button component
        Button button = GetComponent<Button>();

        // Add a listener for the button click event
        button.onClick.AddListener(OnClick);
    }

    // Method to handle the button click event
    void OnClick()
    {
        // Call the method in the SustainabilityBar class to generate sustainability and move the slider
        sustainabilityBar.GenerateSustainabilityAndMoveSlider();
    }
}
