using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // дает возможность сохранить этот класс в файл
public class PlayerData
{
  public float health;
 
  
  public float[] position;
  
  public string[] itemNames;
  public int[] itemAmounts;

  /* public override string ToString()
  {
    
    var inventoryText="";
    for (int i=0; i<  itemNames.Length; i++)
    {
      inventoryText += $"&& {itemNames[i]}: {itemAmounts[i]}";
    }
    return $"{health} {position[0]} {position[1]} {position[2]} {inventoryText}";
  } */

  public PlayerData (Stats indicators, Player_Move player, InventoryManager inventoryManager)
  {
    health = indicators.Health;
    
    
    position = new float[3];
    var playerPosition = player.transform.position;
    position[0] = playerPosition.x;
    position[1] = playerPosition.y;
    position[2] = playerPosition.z; 
    
    Debug.Log($"{playerPosition} {position[0]} {position[1]} { position[2]}");

    itemNames = new string[inventoryManager.slots.Count];
    itemAmounts = new int[inventoryManager.slots.Count];
    
    
    for (int i = 0; i < inventoryManager.slots.Count; i++)
    {
      if(inventoryManager.slots[i].item != null)
        itemNames[i] = inventoryManager.slots[i].item.name;
    }
    
    for (int i = 0; i < inventoryManager.slots.Count; i++)
    {
      if(inventoryManager.slots[i].item != null)
        itemAmounts[i] = inventoryManager.slots[i].amount;
    }
  }
}
