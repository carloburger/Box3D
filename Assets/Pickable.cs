using UnityEngine;
using System.Collections.Generic;
using System;

public class Pickable : MonoBehaviour
{
    [Header("Item Info")]
    public string itemName = "Key";
    public Sprite icon;               

    [Header("Hover Scale")]
    public float hoverScale = 1.3f;
    public float scaleSpeed = 8f;
    private Vector3 originalScale;
    private bool isHovering = false;

    [Header("Highlight")]
    public float outlineStrength = 1.2f;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update() {
        Vector3 targetScale = isHovering ? originalScale * hoverScale : originalScale;
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * scaleSpeed);
    }

    private bool isInRange = false;

    public void SetInRange(bool inRange)
    {
        isHovering = inRange;
    }

    public void PickUp()
    {
        Inventory.Instance.AddItem(itemName);
        Destroy(gameObject); // remove from scene
    }
}