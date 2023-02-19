using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onColliderEnter : MonoBehaviour
{   
    public GameObject Door;
    public GameObject dim;
    
    private bool isColliderEnter=false;
    void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player")&(isColliderEnter==false)&(Door.GetComponent<Door>().isOpen==true))
        {
            isColliderEnter=true;
            Door.GetComponent<Door>().Interact();
            Destroy(dim);
            Destroy(gameObject);

        }
        
    }
    
    

    
}
