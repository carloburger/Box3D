using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    public float interactRange = 3f;

    private Pickable currentPickable;

    void Update()
    {
        CheckForPickable();
        HandleInput();
    }

    void CheckForPickable()
    {
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactRange))
        {
            Pickable pickable = hit.collider.GetComponent<Pickable>();

            if (pickable != null)
            {
                if (currentPickable != pickable)
                {
                    if (currentPickable != null)
                        currentPickable.SetInRange(false);

                    currentPickable = pickable;
                    currentPickable.SetInRange(true);
                }
                return;
            }
        }

        // Not hovering over anything pickable
        if (currentPickable != null)
        {
            currentPickable.SetInRange(false);
            currentPickable = null;
        }
    }

    void HandleInput()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && currentPickable != null)
        {
            currentPickable.PickUp();
            currentPickable = null;
        }
    }
}