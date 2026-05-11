using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryToggler : MonoBehaviour
{
    public InventoryUI inventoryUI; 

    void Update()
    {
        if (Keyboard.current.iKey.wasPressedThisFrame)
            inventoryUI.Toggle();
    }
}