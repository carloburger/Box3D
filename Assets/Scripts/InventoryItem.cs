using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryItem : MonoBehaviour
{
    public ItemSO itemData;

    [SerializeField] Image iconImage;

    void Start(){
        if(itemData != null && iconImage != null)
        {
            iconImage.sprite = itemData.icon;
        }
    }

    public void SetItem(ItemSO item)
    {
        itemData = item;
        if(itemData != null && iconImage != null)
        {
            iconImage.sprite = itemData.icon;
        }
    }
}
