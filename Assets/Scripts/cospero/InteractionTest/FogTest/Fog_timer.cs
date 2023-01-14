using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Fog_timer : MonoBehaviour
{
    [SerializeField] private GameObject Fog;
    bool timerRun = true;
    public float timeStart = 15;
    void Start()
    {
            
        
    }

    
    
    
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        if (timerRun)
        {
            timeStart -= Time.deltaTime;
            if (timeStart < 0)
            {
                timerRun = false;
                Fog.SetActive(true);
            }
        }
    }
}
