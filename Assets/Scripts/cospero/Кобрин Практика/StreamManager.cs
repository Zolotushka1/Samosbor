using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public static class StreamManager 
{
    
    
    
    public static void WriteToFile(List<string> args)
    {
        string path = Application.persistentDataPath + "/logs.txt";
        StreamWriter sw = new StreamWriter(path, true );
        foreach (string i in args)
        {
            sw.WriteLine(i);
        }
        
        

       /*  for ( int i = 1; i <= 10; i++ )
        {
            for ( int j = 1; j <= 10; j++ )
            {
                sw.WriteLine( "{0}x{1}= {2}", i, j, (i*j) );
            }

            sw.WriteLine( "====================================" );
        }

        Console.WriteLine( "Table successfully written to file!" );
        Debug.Log(path); */

        sw.Close();
    }
}