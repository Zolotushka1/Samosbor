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

    public void Play()
    {
        SceneManager.LoadScene(1); //�� ����: ������� ����� 0 �� ����� 1 ��� ����� �������
    }

    public void Load()
    {
        var loadObject=new GameObject();
        var promise=loadObject.AddComponent<LoadPromise>();
        promise.saveName="new_save";
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }

    public void Settings()
    {
        _mainCamera.SetActive(false);
        _settingsCamera.SetActive(true);
        _menuPanel.SetActive(false);
        _settingsPanel.SetActive(true);
    }

}
