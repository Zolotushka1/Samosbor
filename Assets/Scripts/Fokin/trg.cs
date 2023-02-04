using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trg : MonoBehaviour

{
    public GameObject hud;
    public Collider Playe;
    

    // Update is called once per frame
    void OnTriggerEnter(Collider playe)
    {
        hud.SetActive(true);
        StartCoroutine(Hides());
        


    }
    IEnumerator Hides()
    {
        yield return new WaitForSeconds(3.0f);
        hud.SetActive(false);
        Destroy(gameObject);
    }
    
}