using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour
{
    [SerializeField] private Collider Player;
    [SerializeField] private GameObject obj;
    [SerializeField] private bool destroyThisObject = false;

    void OnTriggerEnter(Collider Player)

    {
        {
            obj.SetActive(true);
            if (destroyThisObject == true)
            {
                Destroy(gameObject);
            }
        }
    }
}
