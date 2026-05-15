using UnityEngine;
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

        foreach (string item in Inventory.Instance.GetItems())
        {
            GameObject slot = Instantiate(itemSlotPrefab, slotContainer);
            slot.GetComponentInChildren<TextMeshProUGUI>().text = item;
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