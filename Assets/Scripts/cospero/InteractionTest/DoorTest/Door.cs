using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{

    public Animator DoorAnimator;
    public bool isOpen;
    public Activator activator;

    

    void Start()
    {
        activator = GetComponent<Activator>();
       if (isOpen)
        {
            DoorAnimator.SetBool("IsOpen", true);
        } 
    }

    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            activator.activationLine_RU = "Закрыть";
            activator.activationLine_ENG = "Close";
            DoorAnimator.SetBool("IsOpen", true);
        }
        else
        {
            activator.activationLine_RU = "Открыть";
            activator.activationLine_ENG = "Open";
            DoorAnimator.SetBool("IsOpen", false);
        }
    }
    
}
