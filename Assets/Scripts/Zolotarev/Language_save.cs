using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language_save : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.HasKey("Language") == false)
        {
            if(Application.systemLanguage == SystemLanguage.Russian) PlayerPrefs.SetInt("Language", 0); // Русский
            else PlayerPrefs.SetInt("Language", 1); // Английский
        }
        Translator.Select_language(PlayerPrefs.GetInt("Language"));
    }

    public void Language_change(int languageId)
    {
        PlayerPrefs.SetInt("Language", languageId);
        Translator.Select_language(PlayerPrefs.GetInt("Language"));
    }
}
