using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObjj : MonoBehaviour
{

    public Collider plyer;
    public GameObject SpawnPoint;
    public GameObject ObjSpawn;
    void OnTriggerEnter(Collider plyer)
    {
        Instantiate(ObjSpawn, ObjSpawn.transform.position, Quaternion.identity);
    }
}
