using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    [Header("References")]
    public GameObject itemSlotPrefab;
    public Transform slotContainer;

    void Start()
    {
        Inventory.Instance.OnItemAdded += _ => RefreshUI();
        gameObject.SetActive(false);
    }

    void RefreshUI()
    {
        foreach (Transform child in slotContainer)
            Destroy(child.gameObject);

        foreach (ItemSO item in Inventory.Instance.GetItems())
        {
            GameObject slot = Instantiate(itemSlotPrefab, slotContainer);
            slot.GetComponentInChildren<TextMeshProUGUI>().text = item.itemName;

            Image icon = slot.transform.Find("Icon")?.GetComponent<Image>();
            Debug.Log($"Icon object found: {slot.transform.Find("Icon") != null}");
            Debug.Log($"Icon Image component: {icon != null}");
            Debug.Log($"Item icon sprite: {item.icon != null}");
            
            if (icon != null && item.icon != null)
            {
                icon.sprite = item.icon;
                icon.color = Color.white;
            }

            TextMeshProUGUI nameText = slot.transform.Find("Name")?.GetComponent<TextMeshProUGUI>();
            if (nameText != null)
            {
                nameText.text = item.itemName;
            }

            ItemSO capturedItem = item; // Capture for closure

            
            Button button = slot.GetComponentInChildren<Button>();
            if (button != null) {
            button.onClick.AddListener(() => 
            {
                MainSlot.Instance.SetItem(capturedItem);
                Toggle();
            });
        }
        }   
    }

    public void Toggle()
    {
        bool isOpen = gameObject.activeSelf;
        if (!isOpen) RefreshUI();
        gameObject.SetActive(!isOpen);

        // Unlock cursor when inventory open
        Cursor.lockState = isOpen ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !isOpen;
    }
}