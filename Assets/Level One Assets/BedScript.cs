using UnityEngine;

public class BedScript : MonoBehaviour
{
    public Vector3 upright;
    public Vector3 uprightPos;
    public Vector3 open;
    public Vector3 openPos;
    private bool isUpright = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        upright = transform.eulerAngles;
        uprightPos = transform.position;
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

    void OnMouseDown()
    {
        if (isUpright)
        {
            transform.eulerAngles = open;
            transform.position = openPos;
        }
        else
        {
            transform.eulerAngles = upright;
            transform.position = uprightPos;
        }
        isUpright = !isUpright;
      
    }
}
