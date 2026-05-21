using UnityEngine;

public class TrapdoorScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Camera;
    public Vector3 CamPos;
    public bool isOpen;
    public Vector3 dropPos;

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
            CharacterController cc = Camera.GetComponent<CharacterController>();
            cc.enabled = false;

            if (CamPos.y > drop)
            {
                Camera.transform.position = dropPos;
            }
            else
            {
                Camera.transform.position = new Vector3(5.64f, 0.41f, -11.78f);
            }

            cc.enabled = true;
        }
    }
}
