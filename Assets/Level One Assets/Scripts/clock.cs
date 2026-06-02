using UnityEngine;

public class clock : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject text;
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnMouseDown()
    {
        text.SetActive(true);
    }
}
