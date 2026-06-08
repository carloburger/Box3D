using UnityEngine;

public class Potato : MonoBehaviour
{
    public GameObject clock;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Clock clockscript = clock.GetComponent<Clock>();

        if (clockscript.minutes == 11 && clockscript.hour == 11)
        {
            // Your code for when it's 11:11 goes here
        }
    } // This was the bracket that was missing/misplaced!
}