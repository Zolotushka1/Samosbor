using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class trgWall : MonoBehaviour
{
    public Collider player;
    public waa booleanController;

    void OnTriggerEnter(Collider player)
    {
        booleanController.isClimbing = false;


    }
}
