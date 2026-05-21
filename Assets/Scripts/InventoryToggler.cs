using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryToggler : MonoBehaviour
{
    public InventoryUI inventoryUI; 
    public ObjectToggler objectToggler;

    void Update()
    {
        if (Keyboard.current.iKey.wasPressedThisFrame){
            inventoryUI.Toggle();
            objectToggler.ToggleAsset();
        }
    }
    
}