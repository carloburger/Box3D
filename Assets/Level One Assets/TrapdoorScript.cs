using UnityEngine;

public class TrapdoorScript : MonoBehaviour
{
    public GameObject player;         // drag PlayerCapsule here
    public Vector3 dropPos;           // set to somewhere inside the gap e.g. (3, 2.5, 3)
    public Vector3 surfacePos;        // the position to return to on the surface
    public float drop = -2f;

    private CharacterController cc;
    private bool isBelow = false;

    void Start()
    {
        cc = player.GetComponent<CharacterController>();
    }

    private void OnMouseDown()
    {
        if (!isBelow)
        {
            surfacePos = player.transform.position; // remember where we came from
            TeleportPlayer(dropPos);
            isBelow = true;
        }
        else
        {
            TeleportPlayer(surfacePos);
            isBelow = false;
        }
    }

    private void TeleportPlayer(Vector3 destination)
    {
        cc.enabled = false;
        player.transform.position = destination;
        cc.enabled = true;
    }
}