using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    private GameObject player; 
    public int maxHealth = 100;
    public static int Health;
    public float speed = 6; 
    public float _speed; 
    public int rotation = 250; 
    public int jump = 3; 


    public static bool IsDrawWeapon;  
    public static float x = 0.0f; 
    
    void Start()
    {
        Health = maxHealth;
        IsDrawWeapon = false; 
        _speed = speed; 
        player = (GameObject)this.gameObject; 
    }

    void Update()
    {
        gun();
        die();
    }
    void gun()
    {
        if (IsDrawWeapon == true) 
        {
            speed = _speed; 
            if (Input.GetKey(KeyCode.W)) 
            {
                player.transform.position += player.transform.forward * speed * Time.deltaTime; 
            }
            if (Input.GetKey(KeyCode.S))
            {
                speed = _speed / 2; 
                player.transform.position -= player.transform.forward * speed * Time.deltaTime; 
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                speed = _speed * 2; 
            }
            if (Input.GetKey(KeyCode.A))
            {
                player.transform.position -= player.transform.right * speed * Time.deltaTime; 
            }
            if (Input.GetKey(KeyCode.D))
            {
                player.transform.position += player.transform.right * speed * Time.deltaTime; 
            }
            if (Input.GetKey(KeyCode.Space))
            {
                player.transform.position += player.transform.up * jump * Time.deltaTime; 
            }

            if (Input.GetKey(KeyCode.Keypad1)) 
            {
                IsDrawWeapon = false; 
            }
        }
        else if (IsDrawWeapon == false)
        {
            speed = _speed;
            if (Input.GetKey(KeyCode.LeftShift)) 
            {
                speed = _speed * 2; 
            }
            if (Input.GetKeyUp(KeyCode.LeftShift)) 
            {
                speed = _speed; 
            }
            if (Input.GetKey(KeyCode.W)) 
            {
                player.transform.position += player.transform.forward * speed * Time.deltaTime; 
            }
            if (Input.GetKey(KeyCode.S))
            {
                speed = _speed / 2;
                player.transform.position -= player.transform.forward * speed * Time.deltaTime; 
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                speed = _speed; 
            }
            if (Input.GetKey(KeyCode.A))
            {
                player.transform.position -= player.transform.right * speed * Time.deltaTime; 
            }
            if (Input.GetKey(KeyCode.D))
            {
                player.transform.position += player.transform.right * speed * Time.deltaTime; 
            }
            if (Input.GetKey(KeyCode.Space))
            {
                player.transform.position += player.transform.up * jump * Time.deltaTime; 
            }
            if (Input.GetKey(KeyCode.Keypad2)) 
            {
                IsDrawWeapon = true; 
            }
        }

        
        Quaternion rotate = Quaternion.Euler(0, x, 0); 
        player.transform.rotation = rotate; 



    }
    public static void GetDamage(int DAMAge)
    {
        Health -= DAMAge;
       
    }
    void die()
    {
        if (Health < 1)
        {
            SceneManager.LoadScene(0);
        }
    }
}
