using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SustainabilityBar : MonoBehaviour
{
    [SerializeField] GameBehavior gb;
    [SerializeField] Slider slider;

    // Method to handle the button click event
    public void GenerateSustainabilityAndMoveSlider()
    {
        // Generate sustainability (increase player HP)
        gb.HP += 5;

        // Move the slider based on the updated player HP value
        slider.value = gb.HP;
    }

    // Update is called once per frame
    void Update()
    {
        // Set the slider value to the current player HP
        slider.value = gb.HP;
    }
}
