using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Security.Permissions;

public class Stats : MonoBehaviour
{
    
    [SerializeField] Slider HpSlider;
    [SerializeField] private GameObject[] DestroyOnDeath;
    public float maxHealth = 100f;
    public  float Health;
    public int sceneL = 0;
    public GameObject Player;
    public GameObject Ragdoll;
    public GameObject DeathMenu;
    public GameObject DamageOverlay;
    private Coroutine globalCoroutineHandle;
    private TMP_Text textHp;



    void Start()
    {
        textHp = HpSlider.transform.GetChild(3).GetComponent<TMP_Text>();
        Health = maxHealth;
        
    }
    
    void Update()

    {
        /*if (Input.GetKey(KeyCode.F))
        {
            GetDamage(2f);
        }*/
        HpShow();
    }
    public void GetDamage(float DAMAge)
    {
        Health -= DAMAge;
        if (Health < 0)
        {
            Health = 0;
        }
        
        if (globalCoroutineHandle != null)
            StopCoroutine(globalCoroutineHandle);
        globalCoroutineHandle = StartCoroutine(DamageOverlayPlay());
        


        UnityEngine.Debug.Log(Health);
        if (Health < 1)
        {
            die();
        }
        
    }
    void die()
    {
        if (Health <= 0)
        {

            var rot = Quaternion.Euler(0, 0, 10);
            Player.SetActive(false);
            Ragdoll.SetActive(true);
            var newRagdoll = Instantiate(Ragdoll, transform.position, transform.rotation);
            newRagdoll.transform.Rotate(0, 0, 1);
            newRagdoll.SetActive(true);



            DeathMenu.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            foreach (GameObject ob in DestroyOnDeath)
            {
                ob.SetActive(false);
            }
        }
    }

    private IEnumerator DamageOverlayPlay()
    {
        DamageOverlay.SetActive(true);
        
        yield return new WaitForSeconds(1f);
        DamageOverlay.SetActive(false);
        
    }
    private void HpShow()
    {

        textHp.text = HpSlider.value.ToString();
        HpSlider.value = Health;
    }

}
