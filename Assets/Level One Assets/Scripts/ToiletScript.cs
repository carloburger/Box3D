using UnityEngine;
public class ToiletScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject seat;
    public bool isOpen;
    public Vector3 open;
    public Vector3 close;
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
        Debug.Log("hello");
        if (isOpen)
        {
            seat.transform.eulerAngles = close;
        }
        else
        {
            seat.transform.eulerAngles = open;
        }
        isOpen = !isOpen;
    }
}
