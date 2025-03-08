using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpSystem : MonoBehaviour
{
    public int maxHp;
    public int currentHp;
    public int damage;

    private void Start()
    {
        currentHp = maxHp;
    }

    public void Damage(int damage)
    {
        currentHp -= damage;
        if (currentHp <= 0)
        {
            Debug.Log("Died");
            Destroy(gameObject);
        }
    }
}
