using UnityEngine;
using UnityEngine.InputSystem;

public class clock : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject text;
    public GameObject face;
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            text.SetActive(false);
        }   
    }

    
    public void OnMouseDown()
    {
        text.SetActive(true);
    }

    public void OnMouseEnter()
    {
        face.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
    }
    public void OnMouseExit()
    {
        face.transform.localScale = new Vector3(1f, 1f, 1f);
    }

    public void takeDown()
    {
        Debug.Log("STILL NEED TO CODE THIS");
    }
}
