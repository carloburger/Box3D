using UnityEngine;

public class ToiletScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject seat;
    public bool isOpen;
    void Start()
    {
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (isOpen)
        {
            seat.transform.eulerAngles = new Vector3(90, 0, 0);
        }
        else
        {
            seat.transform.eulerAngles = new Vector3(-90, 0, 0);
        }
        isOpen = !isOpen;
    }
}
