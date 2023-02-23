using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    private static InventoryManager _staticInstance;
    public static void Hide() { _staticInstance.gameObject.SetActive(false); }
    public static void Show() { _staticInstance.gameObject.SetActive(true); }
    private void Awake()
    {
        _staticInstance = this;
        UIPanel.SetActive(true);
    }

    public GameObject UIPanel;
    //private GameObject player;
    public Transform inventoryPanel;
    public List<InventorySlot> slots = new List<InventorySlot>();
    public bool isOpened;
    private Camera mainCamera;
    public float reachDistance = 3f;
    private Player_MouseMove mouseMove;
    [SerializeField] private GameObject[] DestroyOnOpen;

    void Start()
    {
        mainCamera = Camera.main;
        for(int i = 0; i < inventoryPanel.childCount; i++)
        {
            if(inventoryPanel.GetChild(i).GetComponent<InventorySlot>() != null)
            {
                slots.Add(inventoryPanel.GetChild(i).GetComponent<InventorySlot>());
            }
        }
        UIPanel.SetActive(false);
    }

    void Update()
    {
        GameObject player = GameObject.Find("Player");
        mouseMove = player.GetComponent<Player_MouseMove>();
        if(Input.GetKeyDown(KeyCode.I))
        {
            isOpened= !isOpened;
            if(isOpened)            
            {
                UIPanel.SetActive(true);
                mouseMove.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                foreach (GameObject ob in DestroyOnOpen)
                {
                    ob.SetActive(false);
                }
            }
            else
            {
                UIPanel.SetActive(false);
                mouseMove.enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                foreach (GameObject ob in DestroyOnOpen)
                {
                    ob.SetActive(true);
                }
            }
        }
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out hit, reachDistance))
            {
            
                if (hit.collider.gameObject.GetComponent<Item>() != null)
                {
                    AddItem(hit.collider.gameObject.GetComponent<Item>().item, hit.collider.gameObject.GetComponent<Item>().amount);
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
    private void AddItem(ItemScriptableObject _item, int _amount)
    {
        foreach(InventorySlot slot in slots)
        {
            if(slot.item == _item)
            {
                if(slot.amount + _amount <= _item.maximumAmount)
                {
                    slot.amount += _amount;
                    slot.itemAmountText.text = slot.amount.ToString();
                    return;
                }
                break;
            }
        }
        foreach (InventorySlot slot in slots)
        {
            if(slot.isEmpty == true)
            {
                slot.item = _item;
                slot.amount = _amount;
                slot.isEmpty = false;
                slot.SetIcon(_item.icon);
                slot.itemAmountText.text = _amount.ToString();
                break;
            }
        }
    }
}
