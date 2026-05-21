using UnityEngine;

public class ObjectToggler : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private GameObject toggleTarget; // The GameObject to toggle on/off
    public void Start()
    {
        if (toggleTarget == null)
            toggleTarget = gameObject; // Default to self if no target assigned
    }
    public void ToggleAsset()
    {
        if (toggleTarget != null)
        {
            toggleTarget.SetActive(!toggleTarget.activeSelf);
        }
    }
}
