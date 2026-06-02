using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    private Light pointLight;

    void Start()
    {
        pointLight = GetComponentInChildren<Light>();
    }

    void OnMouseDown()
    {
        pointLight.enabled = !pointLight.enabled;
    }
}