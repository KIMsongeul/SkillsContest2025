using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSystem : MonoBehaviour
{
    public int maxHp;
    public int currentHp;
    public Slider Hpslider;

    private void Start()
    {
        currentHp = maxHp;
    }

    public void UpdateHpBar()
    {
        if (Hpslider != null)
        {
            Hpslider.value = currentHp;
        }
    }

    public void Damage(int damage)
    {
        currentHp -= damage;
        UpdateHpBar();
        if (currentHp <= 0)
        {
            Debug.Log("Died");
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
}
