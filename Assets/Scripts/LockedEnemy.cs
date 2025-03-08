using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LockedEnemy : MonoBehaviour
{

    public float wayX;
    public float wayZ;

    private float speed = 3f;
    
    
    private void Update()
    {
        Vector3 movement = new Vector3(wayX, 0, wayZ);
        movement.Normalize();
        transform.position += movement * speed * Time.deltaTime;
    }
}
