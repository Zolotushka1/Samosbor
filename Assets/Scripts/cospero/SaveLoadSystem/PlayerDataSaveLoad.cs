using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataSaveLoad : MonoBehaviour
{
    

    public void SavePlayer()
    {   
        var  _indicators=FindObjectOfType<Stats>();
        var  player_Move=FindObjectOfType<Player_Move>();
        var   _inventoryManager=FindObjectOfType<InventoryManager>();
        BinarySavingSystem.SavePlayer(_indicators,player_Move, _inventoryManager);
    }

    public void LoadPlayer()
    {
        PlayerData data = BinarySavingSystem.LoadPlayer();
        print(data);

        var player_Move=FindObjectOfType<Player_Move>();
        Debug.Log(player_Move.name);

        player_Move.Teleport(new Vector3(
            data.position[0], data.position[1], data.position[2]));

        var _indicators=FindObjectOfType<Stats>();
        _indicators.Health=data.health;

        //_indicators.Health = data.health;
        /* _indicators.waterAmount = data.water;
        _indicators.foodAmount = data.food; */
        
       
        
        /* var _inventoryManager=FindObjectOfType<InventoryManager>();

        for (int i = 0; i < _inventoryManager.slots.Count; i++)
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
