using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteText : MonoBehaviour
{
    
    [SerializeField] GameObject NoteObj;
    [TextArea (3,15)] public string  noteTexts;

    public void NoteInteract()
    {
        NoteObj.GetComponent<NoteManager>().NoteOpen(noteTexts);
    }
}


