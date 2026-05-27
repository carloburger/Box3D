using UnityEngine;

public class ruller : MonoBehaviour
{
    
    public MoveRuller mover;
    private GameObject _me;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _me = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        _me.GetComponent<PadLockEmissionColor>()._isSelect = true;
        _me.GetComponent<PadLockEmissionColor>().BlinkingMaterial();
        mover.SetActiveRuller(mover._rullers.IndexOf(_me));

        for (int i = 0; i< 4; i++)
        {
            if (mover._rullers[i] != _me)
            {
                mover._rullers[i].GetComponent<PadLockEmissionColor>()._isSelect = false;
                mover._rullers[i].GetComponent<PadLockEmissionColor>().BlinkingMaterial();
            }
        }
    }
}
