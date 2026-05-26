using UnityEngine.InputSystem;
using UnityEngine;

public class moveRuller : MonoBehaviour
{
    public GameObject ruller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= 9; i++)
        {
            // Converts number 0-9 to KeyCode.Alpha0 - KeyCode.Alpha9
            if (Input.GetKeyDown(KeyCode.Alpha0 + i))
            {
                Debug.Log("Number pressed: " + i);
            }
        }
    }
}
