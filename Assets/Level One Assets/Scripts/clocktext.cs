using UnityEngine;
using UnityEngine.InputSystem;

public class clocktext : MonoBehaviour
{
    public clock clock;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        openClock();
    }

    public void openClock()
    {
        if (gameObject.activeSelf)
        {
            if (Keyboard.current.digit1Key.wasPressedThisFrame)
            {
                clock.takeDown();
            }
            if (Keyboard.current.digit2Key.wasPressedThisFrame)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
