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
    public AudioSource SwitchAudio;
    
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

                SwitchAudio.Play();
                Light.SetActive(true);

                
            }
            activator.activationLine = "Выключить";
            
        }
        else
        {
            //SwitchAnimator.SetBool("IsOn", true);
            activator.activationLine = "Включить";
            foreach (GameObject Light in Lights)
            {
                SwitchAudio.Play();
                Light.SetActive(false);
            }
        }
    }

    //public void PlaySound(AudioClip clip)
    //{
        //audioSource.PlayOneShot(clip);
    //}
}
