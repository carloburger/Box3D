using UnityEngine;
using UnityEngine.Assemblies;

public class TrapdoorScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Camera;
    public Vector3 CamPos;
    void Start()
    {
        
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
            Camera.transform.position = new Vector3(CamPos.x, CamPos.y - 4, CamPos.z);
        }
    }
}
