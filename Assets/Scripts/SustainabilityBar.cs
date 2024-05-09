using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SustainabilityBar : MonoBehaviour
{
    [SerializeField] GameBehavior gb;
    [SerializeField] Slider slider;

    // Öffentliche Methode, die aufgerufen wird, wenn der Button geklickt wird, um den Slider-Wert um 5 zu erhöhen
    public void IncreaseSliderValueByFive()
    {
        slider.value += 5f;
    }
    public void DummyMethod()
    {
        // Diese Methode wird nicht verwendet, dient aber dazu, die Dropdown-Liste zu aktualisieren
    }


    // Update is called once per frame
    void Update()
    {
        // Setze den Slider-Wert auf den aktuellen Wert der Spieler-HP
        slider.value = gb._playerHP;
    }
}