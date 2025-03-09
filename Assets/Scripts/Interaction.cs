using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class Interaction : MonoBehaviour
{
    private float interactionRange = 4f;

    private enum interactionObjects
    {
        puzzle,
        treasure,
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            //상호작용
        }
    }
}
