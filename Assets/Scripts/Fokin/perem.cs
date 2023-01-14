using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class perem : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Vector3 dir;
    void FixedUpdate ()
    {
        transform.Translate(speed * dir * Time.deltaTime);
    }


}
