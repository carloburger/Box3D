using System;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_BaseColor", Color.red);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddTorque(UnityEngine.Random.Range(1f, 3f), ForceMode2D.Impulse);
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Box")
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.SetColor("_BaseColor", Color.purple);
        }
    }
}