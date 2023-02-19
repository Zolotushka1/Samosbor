using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onColliderEnter : MonoBehaviour
{   
    public GameObject Door;
    public GameObject dim;
    public AudioClip ZVYK;
    public GameObject ObjecticAudio;
    
    private bool isColliderEnter=false;
    void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player")&(isColliderEnter==false)&(Door.GetComponent<Door>().isOpen==true))
        {
            isColliderEnter=true;
            Door.GetComponent<Door>().Interact();
            ObjecticAudio.GetComponent<AudioSource>().PlayOneShot(ZVYK);
            Destroy(dim);
            Destroy(gameObject);

        }
        
    }
    
    

    
}
