using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Inventory;
    public GameObject inventoryPanel;
    public Transform TreasureContent;
    public GameObject inventoryTreasurePrefab;
    private List<TreasureManager> treasures = new List<TreasureManager>();

    private void Awake()
    {
        Inventory = this;
    }

    private void Start()
    {
        Position();
    }

    void Position()
    {
        RectTransform panelRect = inventoryPanel.GetComponent<RectTransform>();
        panelRect.anchorMax = new Vector2(1, 0);
        panelRect.anchorMin = new Vector2(1, 0);
        panelRect.anchoredPosition = new Vector2(-panelRect.rect.width / 2, panelRect.rect.height / 2);
    }

    public void AddTreasure(TreasureManager treasure)
    {
        treasures.Add(treasure);
    }

    public void RemoveTreasure(TreasureManager treasure)
    {
        treasures.Remove(treasure);
    }

    public void ListTreasures()
    {
        foreach (Transform treasure in TreasureContent)
        {
            Destroy(treasure.gameObject);
        }

        foreach (var treasure in treasures)
        {
            GameObject obj = Instantiate(inventoryTreasurePrefab, TreasureContent);
            
            var treasureIcon = obj.transform.Find("TreasureIcon").GetComponent<Image>();
            treasureIcon.sprite = treasure.icon;
        }
    }
}
