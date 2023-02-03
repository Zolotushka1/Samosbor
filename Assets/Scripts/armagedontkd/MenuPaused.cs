using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPaused : MonoBehaviour
{
    
    public GameObject menuPaused;
    public GameObject _settingsPanel;
    bool isMenuPaused = false;
    [SerializeField] private GameObject[] DestroyOnOpen;

    void Start()
    {
        menuPaused.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ActiveMenu();
        }
    }

    public void ActiveMenu()
    {

        isMenuPaused = !isMenuPaused;
        
        if (isMenuPaused)
        {

            menuPaused.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            foreach (GameObject ob in DestroyOnOpen)
            {
                ob.SetActive(false);
            }
        }
        else
        {
            menuPaused.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            foreach (GameObject ob in DestroyOnOpen)
            {
                ob.SetActive(true);
            }
        }
    }


    public void LoadMenu()
    {
        SceneManager.LoadScene(2);

    }
    public void EnterSettings()
    {
        menuPaused.SetActive(false);
        _settingsPanel.SetActive(true);
    }

}
