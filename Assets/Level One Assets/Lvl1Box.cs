using UnityEngine;

public class Lvl1Box : MonoBehaviour
{
    public float colorChangeInterval = 5f;
    private Renderer rend;
    private float timer;
    private int index = 0;

    private Color[] colours = new Color[]
    {
        Color.purple,
        Color.red,
        Color.green,
        Color.brown,
        Color.yellow
    };
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.SetColor("_BaseColor", Random.ColorHSV());
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= colorChangeInterval)
        {
            index = (index + 1) % 5;
            rend.material.SetColor("_BaseColor", colours[index]);
            timer = 0f;
        }
    }
}