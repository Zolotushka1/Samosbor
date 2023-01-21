using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stats : MonoBehaviour
{
    public float maxHealth = 100f;
    public static float Health;
    public int sceneL = 0;
    public GameObject Player;
    public GameObject Ragdoll;
    public GameObject DeathMenu;
    [SerializeField] private GameObject UiCursor;
    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;
    }

    // Update is called once per frame
    
    public  void GetDamage(float DAMAge)
    {
        Health -= DAMAge;
        UnityEngine.Debug.Log(Health);
        if (Health < 1)
        {
            die();
        }
    }
    void die()
    {
        if (Health < 1)
        {
            Quaternion rot = new Quaternion(0f, 0f, 0.05f, 1);
            Player.SetActive(false);
            Ragdoll.SetActive(true);
            Instantiate(Ragdoll, transform.position,rot );
            UiCursor.SetActive(false);
            DeathMenu.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //SceneManager.LoadScene(sceneL);
        }
    }
    
}
