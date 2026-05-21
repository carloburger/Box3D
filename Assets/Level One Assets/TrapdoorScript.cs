using UnityEngine;
using UnityEngine.Assemblies;

public class TrapdoorScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Camera;
    public Vector3 CamPos;
    public bool isOpen;

    public float drop;
    void Start()
    {
        CamPos = Camera.transform.position;
        isOpen = true;
    }

    // Update is called once per frame
    void Update()
    {
        CamPos = Camera.transform.position;
    }

    private void OnMouseDown()
    {
        if (gameObject.activeSelf)
        {
            if (CamPos.y > (float)drop)
            {
                Camera.transform.position = new Vector3((float)4.6, (float)-2.96, (float)-16.32);
                Debug.Log(Camera.transform.position);
            }
            else
            {
                Camera.transform.position = new Vector3((float)5.64, (float)0.41, (float)-11.78);
            }

        }
        
    }
}
