using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPaused : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject menuPaused;
    [SerializeField] private GameObject _settingsPanel;
    [SerializeField] private GameObject[] DestroyOnOpen;
    bool isMenuPaused = false;

    void Start()
    {
        menuPaused.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ActiveMenu();
        }
    }

    public void ActiveMenu()
    {
        var enabler = player.GetComponent<MoveEnabler>();
        var sounds = player.transform.GetChild(1).gameObject;
        isMenuPaused = !isMenuPaused;

        if (isMenuPaused)
        {
            sounds.SetActive(false);
            enabler.enableController = false;
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
            sounds.SetActive(true);
            enabler.enableController = true;
            menuPaused.SetActive(false);
            _settingsPanel.SetActive(false);
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
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;

    }
    public void EnterSettings()
    {
        menuPaused.SetActive(false);
        _settingsPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
