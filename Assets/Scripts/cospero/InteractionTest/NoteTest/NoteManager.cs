using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NoteManager : MonoBehaviour
{
    [SerializeField] TMP_Text NoteText;
    [SerializeField] GameObject NoteObj;
    [SerializeField] private GameObject[] DestroyOnOpen;
    private bool OverlayOn;
    void Start()
    {
        OverlayOn=false;
        NoteObj.SetActive(false);
    }

    public void NoteOpen(string NoteTextss)
    {
        if (OverlayOn==false)
        {
            NoteText.text=NoteTextss;
            OverlayOn=true;
            NoteObj.SetActive(true);
            Time.timeScale=0f;
            foreach (GameObject ob in DestroyOnOpen)
                {
                    ob.SetActive(false);
                }
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void NoteClose()
    {
        OverlayOn=false;
        Time.timeScale=1f;
        NoteObj.SetActive(false);
         foreach (GameObject ob in DestroyOnOpen)
            {
                ob.SetActive(true);
            }
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    private void  Update() 
    {
        if ((Input.GetKeyDown(KeyCode.E))&&(OverlayOn==true))
        {
           NoteClose();
        }
    }
}
