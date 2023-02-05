using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class perem : MonoBehaviour
{
    // Start is called before the first frame update
    public float tine;
    public float speed;
    public Vector3 dir;
    void Start()
    {
        StartCoroutine(oble());

    }
    void FixedUpdate()

    {
        transform.Translate(speed * dir * Time.deltaTime);
    }
    IEnumerator oble()
    {
        yield return new WaitForSeconds(tine);
        Destroy(gameObject);


    }
}
