using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class JsonWriteTest : MonoBehaviour
{

    public float JsonSaveStartTime;
    private float JsonSaveLastTime;
    public Jstable jsonTable; 
    public GameObject achManager;
    
    static List<string> logData=new List<string>() {}; 
   
    void Start()
    {
        LoadJson();
        JsonsetTime();
    }

    private void JsonsetTime()
    {
        JsonSaveLastTime=JsonSaveStartTime;
    }

    public void LoadJson()
    {
        jsonTable=JsonUtility.FromJson<Jstable>(File.ReadAllText(Application.persistentDataPath+"/JsonTableTest.json"));
    }
    public  void AddToLogs(string LogStr,int amount, int TableIndex)
    {
        if (TableIndex==0)
        {
            
            jsonTable.ApplesPiked += amount;
        }
        else if ( TableIndex==1)
        {
            jsonTable.MobsKilled += amount;
        }
        else if (TableIndex==2)
        {
            jsonTable.StashOpened += amount;
        }
        else if (TableIndex==3)
        {
            jsonTable.QuestsComplited += amount;
        }
        else if (TableIndex==4)
        {
            jsonTable.ItemsCrefted += amount;
        }
        
       
    }

    void Update()
    {
        JsonSaveLastTime-=Time.deltaTime;
        if (JsonSaveLastTime<=0)
        {
            achManager.GetComponent<AchievementManager>().WtiteLn();
            SaveJson();
            JsonsetTime();
        }
    }

    public void SaveJson()
    {
        /* string JsonPath= Application.persistentDataPath + "/JsonTableTest.txt"; */
        File.WriteAllText(Application.persistentDataPath+"/JsonTableTest.json", JsonUtility.ToJson(jsonTable));
    }

    [System.Serializable]
    public class Jstable
    {
        
        public int ApplesPiked =0;
        public int MobsKilled=0;
        public int StashOpened=0;
        public int QuestsComplited=0;
        public int ItemsCrefted=0;

        
    } 
   
} 
