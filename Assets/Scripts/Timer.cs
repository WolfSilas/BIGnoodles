using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float targetTime = 60.0f;
    public GameObject priceTimer;

    public void Update()
    {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            priceTimer.SetActive(false);
        }

    }

   
}
