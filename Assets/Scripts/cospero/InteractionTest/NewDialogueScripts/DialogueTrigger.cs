using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public string Npc_Name;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    

    public void Activation()
    {
        DialogueManagerTest.GetInstance().EnterDialogueMode(inkJSON);
    }
   
         
          
}