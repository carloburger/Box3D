using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class clock : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject text;
    public GameObject face;
    public GameObject cam;
    public GameObject play;
    private bool down;
    void Start()
    {
        text.SetActive(false);
        down = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            text.SetActive(false);

            // If the clock is taken down, then we put the clock back, okay?
            if (down)
            {
                play.GetComponent<FirstPersonController>().enabled = true;
                play.GetComponent<StarterAssetsInputs>().cursorInputForLook = true;
                play.GetComponent<StarterAssetsInputs>().cursorLocked = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

                transform.localScale = new Vector3(1f, 1f, 1f);
                transform.eulerAngles = new Vector3(0, 0, 0);
                transform.position = new Vector3(-0.5804806f, 5.454f, 0.001f);
                down = false;
            }
        }
    }

    
    public void OnMouseDown()
    {
        text.SetActive(true);
    }

    public void OnMouseEnter()
    {
        if(cam.transform.position.z < -9)
        {
            face.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
        }
    }
    public void OnMouseExit()
    {
        face.transform.localScale = new Vector3(1f, 1f, 1f);
    }

    // This is the screen when we choose to take the clock down from the wall. 
    public void takeDown()
    {
        play.GetComponent<FirstPersonController>().enabled = false;
        play.GetComponent<StarterAssetsInputs>().cursorInputForLook = false;
        play.GetComponent<StarterAssetsInputs>().cursorLocked = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        transform.localScale = new Vector3(5f, 5f, 5f);
        transform.eulerAngles = new Vector3(0, 180, 0);
        transform.position = new Vector3(-0.5804806f, 7, 0.001f);
        down = true;
    }

}
