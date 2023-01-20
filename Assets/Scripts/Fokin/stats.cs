using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class stats : MonoBehaviour
{
    
    [SerializeField] Slider HpSlider;
    [SerializeField] private GameObject[] DestroyOnDeath;
    public float maxHealth = 100f;
    public static float Health;
    public int sceneL = 0;
    public GameObject Player;
    public GameObject Ragdoll;
    public GameObject DeathMenu;
    
    private TMP_Text textHp;




    // Start is called before the first frame update
    void Start()
    {
        textHp = HpSlider.transform.GetChild(3).GetComponent<TMP_Text>();
        Health = maxHealth;
    }

    // Update is called once per frame
    
    void Update()

    {
        if (Input.GetKey(KeyCode.F))
        {
            GetDamage(2f);
        }
        HpShow();
    }
    public  void GetDamage(float DAMAge)
    {
        Health -= DAMAge;
        if (Health < 0)
        {
            Health = 0;
        }
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
            
                
            DeathMenu.SetActive(true);
            Cursor.visible = true;
            foreach (GameObject ob in DestroyOnDeath)
            {
                ob.SetActive(false);
            }
            Cursor.lockState = CursorLockMode.None;
            //SceneManager.LoadScene(sceneL);
        }
    }

    private void HpShow()
    {

        textHp.text = HpSlider.value.ToString();
        HpSlider.value = Health;
    }

}
