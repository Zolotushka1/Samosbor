using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScripts : MonoBehaviour
{

    public int DAMAge = 16;
    private void OnCollisionEnter(Collision collision)
    {
        stats.GetDamage(DAMAge);
    }
}
