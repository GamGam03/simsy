using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider foodSlider;

    public float sliderTimer;

    public bool stopTimer = false;

    void Start()
    {
        foodSlider.maxValue = sliderTimer;
        foodSlider.value = sliderTimer;
        StartTimer();
    }

    public void StartTimer()
    {
        StartCoroutine(StartTimerTicker());
    }

    IEnumerator StartTimerTicker()
    {
        while (stopTimer == false)
        {
            sliderTimer -= Time.deltaTime;
            yield return new WaitForSeconds(0.001f);

            if (sliderTimer <= 0)
            {
                stopTimer = true;
            }
                
            if(stopTimer == false)
            {
                foodSlider.value = sliderTimer;
            }
        }
        
    }
}
