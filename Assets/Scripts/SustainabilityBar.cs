using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SustainabilityBar : MonoBehaviour
{
    [SerializeField] GameBehavior gb;
    [SerializeField] Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.GetComponent<Slider>().value = gb._playerHP;

        
    }
}
