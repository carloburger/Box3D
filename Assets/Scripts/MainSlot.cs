using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainSlot : MonoBehaviour
{
    public static MainSlot Instance { get; private set; }

    [Header("References")]
    public Image iconImage;
    public TextMeshProUGUI itemName;

    [Header("Empty State")]
    public Sprite emptySprite;
    public Color emptyColor = Color.gray;
    public Color filledColor = Color.white;

    private ItemSO activeItem;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClearSlot();
    }


    public void SetItem(ItemSO item)
    {
        activeItem = item;

        iconImage.sprite = item.icon;
        iconImage.color = filledColor;
        itemName.text = item.name;
    }

    public void ClearSlot()
    {
        activeItem = null;
        iconImage.sprite = emptySprite;
        iconImage.color = emptyColor;
        itemName.text = "";
    }
}
