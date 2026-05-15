using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem; 

public class CameraScript : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 1f;

    void Update()
    {
        // Modern Input System check
        if (Keyboard.current.upArrowKey.isPressed)
        {
            controller.SimpleMove(Vector3.forward * moveSpeed);
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            controller.SimpleMove(Vector3.back * moveSpeed);
        }
        if (Keyboard.current.leftArrowKey.isPressed){
            controller.SimpleMove(Vector3.left * moveSpeed);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            controller.SimpleMove(Vector3.right * moveSpeed);
        }
    }
}