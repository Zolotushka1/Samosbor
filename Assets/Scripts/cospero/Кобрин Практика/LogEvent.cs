using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class LogEvent : MonoBehaviour
{
    public int EventAmount;
    public string EventName;
    public int LogIndex; //обязательно должен соответсвовать индекву EventName в массиве Jstable в AchievementManager
    private string actualTime;
    private string date;
    private string EvAmountSrt;
    public GameObject achManager;
    
     private  void OnTriggerEnter(Collider other) 
     {
        
        if ((other.tag == "Player") ^ (other.tag == "LogBot"))
        {
            actualTime=System.DateTime.Now.ToString("hh:mm:ss");
            date=System.DateTime.Now.ToString("MM/dd/yyyy");
            EvAmountSrt=EventAmount.ToString();
            achManager.GetComponent<JsonWriteTest>().AddToLogs(EventName, EventAmount, LogIndex);
            achManager.GetComponent<AchievementManager>().AddToLogs(EventName+" "+ EventAmount + " " + actualTime+ " "+ date );
            Debug.Log(LogIndex);
        }
     }
        
}
    