// Script by Marcelli Michele

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveRuller : MonoBehaviour
{
    PadLockPassword _lockPassword;
    PadLockEmissionColor _pLockColor;
    public bool isUnlocked = false;

    [HideInInspector]
    public List <GameObject> _rullers = new List<GameObject>();
    private int _scroolRuller = 0;
    private int _changeRuller = 0;
    [HideInInspector]
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
        RotateRullers();
    }

    void RotateRullers()
    {
        Key[] numberKeys = {
            Key.Digit0, Key.Digit1, Key.Digit2, Key.Digit3, Key.Digit4,
            Key.Digit5, Key.Digit6, Key.Digit7, Key.Digit8, Key.Digit9
        };
            for (int i = 0; i <= 9; i++)
        {
            // Converts number 0-9 to KeyCode.Alpha0 - KeyCode.Alpha9
            if (Keyboard.current[numberKeys[i]].wasPressedThisFrame)
            {
                _isActveEmission = true;
                _scroolRuller = 36;
                _rullers[_changeRuller].transform.Rotate(-_scroolRuller, 0, 0, Space.Self);
                _numberArray[_changeRuller] = i;
                _lockPassword.Password();
            }
        }
    }

    public void SetActiveRuller(int index)
    {
        _changeRuller = index;
    }
}

