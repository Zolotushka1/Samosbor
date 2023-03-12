using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class Fog_script : MonoBehaviour
{

    public GameObject player;
    
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject enteredObject = other.gameObject;
            player.GetComponent<Stats>().GetDamage(0.3f);
            UnityEngine.Debug.Log(enteredObject.name);
        }
    }
}
