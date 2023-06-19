using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousSensitivity : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private const string PREFS_KEY = "MouseSensitivity";
    public static float GetValue() 
    {
        return PlayerPrefs.GetFloat("MouseSensitivity");
    }
    public void Start() 
    {
        var slider = GetComponent<UnityEngine.UI.Slider>();
        slider.value = GetValue();
    }

    public void SetValue(float value)
    {
        PlayerPrefs.SetFloat(PREFS_KEY, value);
        var slider = player.GetComponent<Mouse_Control>();
        slider.sensitivity = value;
    }
    
    
}
