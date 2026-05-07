using System;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_BaseColor", Color.red);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(UnityEngine.Random.Range(1f, 3f), 0f, UnityEngine.Random.Range(1f, 3f)), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
