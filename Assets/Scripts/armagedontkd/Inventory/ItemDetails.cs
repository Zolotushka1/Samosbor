using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class ItemDetails : MonoBehaviour
{
    // статичный функционал
    public static void ActivateWith(ItemScriptableObject itemType)
    {
        _staticInstance.gameObject.SetActive(true);
        _staticInstance.Use(itemType);
        
    }

    // синглтон
    private static ItemDetails _staticInstance;
    
    public void ReturnToInventory()
    {
        gameObject.SetActive(false);
        InventoryManager.Show();
    }
    private void Awake()
    {
        _staticInstance = this;
        gameObject.SetActive(false);
    }

    // внутри синглтона
    [SerializeField] private GameObject panel;
    [SerializeField] private Image itemIcon;
    [SerializeField] private TMP_Text description;
    public void Use(ItemScriptableObject itemType)
    {
        
        panel.SetActive(true);
        itemIcon.sprite = itemType.icon;
        description.text = itemType.itemDescription;

    }
}
