// Script by Marcelli Michele

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveRuller : MonoBehaviour
{
    PadLockPassword _lockPassword;
    PadLockEmissionColor _pLockColor;
    public bool isUnlocked = false;

    
    public List <GameObject> _rullers = new List<GameObject>();
    private int _scroolRuller = 0;
    private int _changeRuller = 0;
    
    public int[] _numberArray = {0,0,0,0};

    private int _numberRuller = 0;

    private bool _isActveEmission = false;

    [System.Obsolete]
    void Awake()
    {
        _lockPassword = FindObjectOfType<PadLockPassword>();
        _pLockColor = FindObjectOfType<PadLockEmissionColor>();

        _rullers.Add(GameObject.Find("Ruller1"));
        _rullers.Add(GameObject.Find("Ruller2"));
        _rullers.Add(GameObject.Find("Ruller3"));
        _rullers.Add(GameObject.Find("Ruller4"));

        foreach (GameObject r in _rullers)
        {
            r.transform.Rotate(-144, 0, 0, Space.Self);
        }
    }
    void Update()
    {

    }

    public void RotateRullers(int index)
    {
        _isActveEmission = true;
        _scroolRuller = 36;
        _rullers[index].transform.Rotate(-_scroolRuller, 0, 0, Space.Self);
        _numberArray[index] += 1;
        _lockPassword.Password();
    }

    public void SetActiveRuller(int index)
    {
        // Deselect all rulers first
        foreach (GameObject r in _rullers)
        {
            r.GetComponent<PadLockEmissionColor>()._isSelect = false;
        }

        // Select only the active one
        _changeRuller = index;
        _rullers[_changeRuller].GetComponent<PadLockEmissionColor>()._isSelect = true;
    }
}

