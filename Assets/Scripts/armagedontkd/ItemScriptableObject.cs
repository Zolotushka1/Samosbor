using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType {Default,Food,Weapon,Instrument}
public class ItemScriptableObject : ScriptableObject
{
    public string itemName; //имя предмета
    public int maxAmount; // максимальное колво стака
    public GameObject itemPrefab;
    public ItemType itemType;
    public string itemDescription; //описание предмета
}
