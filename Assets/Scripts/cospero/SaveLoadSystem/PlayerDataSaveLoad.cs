using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataSaveLoad : MonoBehaviour
{
    [SerializeField] private Stats _indicators;
    [SerializeField] private Player_Move player_Move;
    [SerializeField] private InventoryManager _inventoryManager;
    

    public void SavePlayer()
    {
        BinarySavingSystem.SavePlayer(_indicators,player_Move, _inventoryManager);
    }

    public void LoadPlayer()
    {
        PlayerData data = BinarySavingSystem.LoadPlayer();

        _indicators.Health = data.health;
        /* _indicators.waterAmount = data.water;
        _indicators.foodAmount = data.food; */
        
       /*  player_Move.transform.position =
            new Vector3(data.position[0], data.position[1], data.position[2]); */
        
        /* for (int i = 0; i < _inventoryManager.slots.Count; i++)
        {
            if (data.itemNames[i] != null)
            {
                _inventoryManager.RemoveItemFromSlot(i);
                ItemScriptableObject item = Resources.Load<ItemScriptableObject>($"ScriptableObjects/{data.itemNames[i]}");
                int itemAmount = data.itemAmounts[i];
                _inventoryManager.AddItemToSlot(item,itemAmount,i);
            }
            else
            {
                _inventoryManager.RemoveItemFromSlot(i);
            }
        } */
        
        
    }
    
}
