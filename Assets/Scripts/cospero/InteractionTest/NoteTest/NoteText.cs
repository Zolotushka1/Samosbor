using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteText : MonoBehaviour
{
    
    [SerializeField] GameObject NoteObj;
    [TextArea (3,15)] public string  noteTexts_RU;
    [TextArea (3,15)] public string  noteTexts_ENG;

    public void NoteInteract()
    {
        if (Translator.LanguageId == 0)
        {
            NoteObj.GetComponent<NoteManager>().NoteOpen(noteTexts_RU);   
        }
        else if (Translator.LanguageId == 1)
        {
            NoteObj.GetComponent<NoteManager>().NoteOpen(noteTexts_ENG); 
        }
    }
}


