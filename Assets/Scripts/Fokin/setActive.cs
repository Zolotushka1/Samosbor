using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour
{
    public Collider Player;
    public GameObject obj;

    void OnTriggerEnter(Collider Player)

    {
        if (obj == false)
        {
            obj.SetActive(true);
            Destroy(gameObject);
        }
        if (obj == true)
        {
            obj.SetActive(false);
            Destroy(gameObject);
        }

    }
}
