using UnityEngine;
using System.Collections.Generic;
using System;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance { get; private set; }

    private List<string> items = new List<string>();

    public event Action<string> OnItemAdded;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
            Instance = this;
    }

    public void AddItem(string item)
    {
        items.Add(item);
        Debug.Log($"Added {item} to inventory.");
        OnItemAdded?.Invoke(item);
    }

    public bool HasItem(string item)
    {
        return items.Contains(item);
    }

    public List<string> GetItems() => items;

    
}
