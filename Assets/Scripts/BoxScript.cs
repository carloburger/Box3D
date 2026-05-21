using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BoxScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ItemSO Key;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Inventory.Instance.HasItem(Key)){
            SceneManager.LoadScene("Level One");
        }
    }
}
