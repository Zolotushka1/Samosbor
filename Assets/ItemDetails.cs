using UnityEngine;
using UnityEngine.UI;

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
    private void Awake()
    {
        _staticInstance = this;
        gameObject.SetActive(false);
    }

    // внутри синглтона
    [SerializeField] private GameObject panel;
    [SerializeField] private Image itemIcon;
    public void Use(ItemScriptableObject itemType)
    {
        panel.SetActive(true);
        itemIcon.sprite = itemType.icon;
    }
}
