// Script by Marcelli Michele

using UnityEngine;

public class PadLockEmissionColor : MonoBehaviour
{
    TimeBlinking tb;

    private GameObject _myRuller;
    public MoveRuller moveRuller;

    public bool _isSelect;
    public int index;

    //[SerializeField] private float _timeBlinking = 0.5f;

    private void Awake()
    {
        tb = FindObjectOfType<TimeBlinking>();
    }
    void Start()
    {
        _myRuller = gameObject;
        _isSelect = false;
        transform.SetAsLastSibling();
    }

    void Update()
    {
        BlinkingMaterial();
    }

    public void OnMouseDown()
    {
        Debug.Log(index + "heha");
        moveRuller.SetActiveRuller(index);
        if (_isSelect)
        {
            moveRuller.RotateRullers(index);
        }
    }

    public void BlinkingMaterial()
    {
        _myRuller.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        
        if (_isSelect)
        {
            Debug.Log(index);
            _myRuller.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.Lerp(Color.clear, Color.yellow, Mathf.PingPong(Time.time, tb.blinkingTime)));
        }
        if (_isSelect == false)
        {
            _myRuller.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.clear);
        }

    }
}
