using UnityEngine;
using UnityEngine.Assemblies;

public class TrapdoorScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Camera;
    public Vector3 CamPos;

    public float drop;
    void Start()
    {
        CamPos = Camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.activeSelf)
        {
            CamPos = Camera.transform.position;
            if (CamPos.y > drop)
            {
                Camera.transform.position = new Vector3(CamPos.x, CamPos.y - 4, CamPos.z);
            }
            else
            {
                Camera.transform.position = new Vector3(CamPos.x, CamPos.y + 4, CamPos.z);
            }
        }
        
    }
}
