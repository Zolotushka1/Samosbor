using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class Light_Switch : MonoBehaviour
{
    [SerializeField] private GameObject[] Lights;
    //public Animator SwitchAnimator;
    public Activator activator;
    public bool isOn;
    
    
    void Start()
    {   
        activator = GetComponent<Activator>();
        if (isOn)
        {
            foreach (GameObject Light in Lights)
            {
                
                Light.SetActive(true);
            }

        }
        else
        {
            foreach (GameObject Light in Lights)
            {
                
                Light.SetActive(false);
            }
            
        }
        
        
        
    }

    public void Switch()
    {
        isOn = !isOn;
        if (isOn)
        {
            //SwitchAnimator.SetBool("IsOn", false);
            foreach (GameObject Light in Lights)
            {

                
                Light.SetActive(true);

                
            }
            activator.activationLine_RU = "Выключить";
            activator.activationLine_ENG = "Off";
            
        }
        else
        {
            //SwitchAnimator.SetBool("IsOn", true);
            activator.activationLine_RU = "Включить";
            activator.activationLine_ENG = "On";
            foreach (GameObject Light in Lights)
            {
                
                Light.SetActive(false);
            }
        }
    }

    //public void PlaySound(AudioClip clip)
    //{
        //audioSource.PlayOneShot(clip);
    //}
}
