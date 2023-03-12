using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDisabler : MonoBehaviour
{
    //public Collider Player;
    public MoveEnabler player;
    void OnTriggerEnter(Collider Player)
    {
        {
            player.enableController = false;
        }
    }
}
