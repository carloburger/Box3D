using System;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_BaseColor", Color.red);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(UnityEngine.Random.Range(1f, 3f), 0f, UnityEngine.Random.Range(1f, 3f)), ForceMode.Impulse);
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Box")
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.SetColor("_BaseColor", Color.purple);
        }
    }
}