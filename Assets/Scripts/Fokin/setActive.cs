using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour
{
    public Collider Player;
    public GameObject obj;

    void OnTriggerEnter(Collider Player)

    {
        {
            obj.SetActive(true);
            Destroy(gameObject);
        }
    }
}
