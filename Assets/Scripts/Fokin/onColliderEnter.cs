using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onColliderEnter : MonoBehaviour
{   

    public GameObject Door;
    public Collider Player
    public GameObject dim;
    public AudioClip ZVYK;
    public GameObject ObjecticAudio;
    
    
    void OnTriggerEnter(Collider Player)
    {
        {
            Door.GetComponent<Door>().Interact();
            ObjecticAudio.GetComponent<AudioSource>().PlayOneShot(ZVYK);
            Destroy(dim);
            Destroy(gameObject);

        }
        
    }
    
    

    
}
