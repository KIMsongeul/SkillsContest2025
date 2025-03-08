using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2System : MonoBehaviour
{
    public Slider O2Slider;
    private int O2speed = 3;

    private void Start()
    {
        O2Slider.value = Single.MaxValue;
    }

    private void Update()
    {
        // if (저압용 산소통)
        // {
        //     
        // }
        // if (중압용 산소통)
        // {
        //     
        // }
        // if (고압용 산소통)
        // {
        //     
        // }
        O2Slider.value -= Time.deltaTime * O2speed;

        if (O2Slider.value <= 0)
        {
            
        }


    }
}
