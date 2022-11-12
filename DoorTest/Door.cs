using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    public Animator DoorAnimator;
    public bool isOpen;


    public interface IInteractable
    {

    }

    void Start()
    {
       if (isOpen)
        {
            DoorAnimator.SetBool("isOpnen", true);
        } 
    }

    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            DoorAnimator.SetBool("isOpnen", true);
        }
        else
        {
            DoorAnimator.SetBool("isOpnen", false);
        }
    }
    
}
