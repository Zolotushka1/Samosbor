using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private GameObject _mainCamera;
    [SerializeField] private GameObject _settingsCamera;
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _settingsPanel;
    [SerializeField] private GameObject _entryAttention;
    [SerializeField] private string url;

    public void Play()
    {
        SceneManager.LoadScene(1); //От Жени: поменял сцену 0 на сцену 1 для билда проекта
    }

    public void Entry()
    {
        _entryAttention.SetActive(true);
        _menuPanel.SetActive(false);
    }

    public void URLOpen()
    {
        Application.OpenURL(url);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }

    public void BackToMenu()
    {
        _entryAttention.SetActive(false);
        _menuPanel.SetActive(true);
    }

    public void Settings()
    {
        _mainCamera.SetActive(false);
        _settingsCamera.SetActive(true);
        _menuPanel.SetActive(false);
        _settingsPanel.SetActive(true);
    }

}
