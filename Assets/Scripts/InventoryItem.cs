using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryItem : MonoBehaviour
{
    public ItemSO itemData;

    [SerializeField] Image iconImage;

    // Update is called once per frame
    void Update()
    {
        if(itemData != null && iconImage != null)
        {
            iconImage.sprite = itemData.icon;
        }
    }
}
