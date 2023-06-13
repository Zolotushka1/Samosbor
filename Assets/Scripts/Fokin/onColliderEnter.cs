using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onColliderEnter : MonoBehaviour
{

    public GameObject Door;
    public Collider Player;
    public GameObject SamosborStop;
    public AudioClip Sound;
    public GameObject ObjecticAudio;
    public GameObject presentDoor;


    void OnTriggerEnter(Collider Player)
    {
        {
            Door.GetComponent<Door>().Interact();
            ObjecticAudio.GetComponent<AudioSource>().PlayOneShot(Sound);
            Destroy(SamosborStop);
            Destroy(gameObject);
            Destroy(presentDoor.GetComponent<Activator>());
        }

    }




}