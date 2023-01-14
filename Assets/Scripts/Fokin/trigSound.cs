using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class trigSound : MonoBehaviour
{
    public Collider Player;
    public AudioClip SCaudio;
    public GameObject ObjectAudio;
    void OnTriggerEnter (Collider Player)
    {
        ObjectAudio.GetComponent<AudioSource>().PlayOneShot(SCaudio);
        Destroy(gameObject);
    }

  
}
