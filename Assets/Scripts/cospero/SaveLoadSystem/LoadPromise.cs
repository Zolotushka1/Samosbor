using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPromise : MonoBehaviour
{
    public string saveName = "firstSave";
    public void Awake()
    {
        GameObject.DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        CallLoadFunctions();
        SceneManager.sceneLoaded -= OnSceneLoaded;
        Destroy(gameObject);
    }
    private void CallLoadFunctions()
    {
        FindObjectOfType<PlayerDataSaveLoad>().LoadPlayer();
    }
}