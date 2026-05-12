using UnityEngine;

public class BedScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "MainCamera" && Input.GetKeyDown(KeyCode.B) == true)
        {
            // I don't know, pick up the object? 
        }
    }
}
