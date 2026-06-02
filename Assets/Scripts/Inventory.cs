using UnityEngine;
using System.Collections.Generic;
using System;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance { get; private set; }

    private List<ItemSO> items = new List<ItemSO>();

    public event Action<ItemSO> OnItemAdded;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
            Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public void AddItem(ItemSO item)
    {
        items.Add(item);
        Debug.Log($"Added {item} to inventory.");
        OnItemAdded?.Invoke(item);
    }

    public bool HasItem(ItemSO item)
    {
        return items.Contains(item);
    }

    public List<ItemSO> GetItems() => items;

    
}
