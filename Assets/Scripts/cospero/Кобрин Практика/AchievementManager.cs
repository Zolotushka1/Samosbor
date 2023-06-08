using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class AchievementManager : MonoBehaviour
{
    
    
    static List<string> logData=new List<string>() {}; 
   
    public void WtiteLn()
    {
        string path = Application.persistentDataPath + "/logs.txt";
        bool fileExist = File.Exists(path);
        
       if (fileExist) 
        {
            
            StreamManager.WriteToFile(logData);
            logData.Clear();
        }
        else
        {
            using (FileStream fs = File.Create(path));  
              StreamManager.WriteToFile(logData);  
        }  
    }

    public  void AddToLogs(string LogStr)
    {
        logData.Add(LogStr);
        
        
        
    }


    
 
    
   
} 
