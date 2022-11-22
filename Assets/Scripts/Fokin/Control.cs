using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    private GameObject player;
    public GameObject weapon1;
    public GameObject weapon2;
    public float speed = 6;
    public float _speed;
    public float DashSpeed = 50;
    public bool isGrounded;
    public bool IsDrawWeapon;
    public bool Weapon;


    void Start()
    {
        IsDrawWeapon = false;
        Weapon = false;
        _speed = speed;
        player = (GameObject)this.gameObject;
    }

    void Update()
    {
        Move();
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void Move()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = _speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                speed = _speed * 2;
            }
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.transform.position += player.transform.forward * speed * Time.deltaTime * DashSpeed;
            }
            
           


        }
        if (Input.GetKey(KeyCode.S))
        {
            speed = _speed / 2;
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            speed = _speed * 2;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.transform.position -= player.transform.forward * speed * Time.deltaTime * DashSpeed;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position -= player.transform.right * speed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.transform.position -= player.transform.right * speed * Time.deltaTime * DashSpeed;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += player.transform.right * speed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.transform.position += player.transform.right * speed * Time.deltaTime * DashSpeed;
            }
        }
        if (IsDrawWeapon == false)
        { 
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                if (Weapon == false)
                {
                    weapon1.SetActive(true);
                    weapon2.SetActive(false);
                    IsDrawWeapon = true;
                }
                else if (Weapon == true)
                {
                    weapon1.SetActive(false);
                    weapon2.SetActive(true);
                    IsDrawWeapon = true;
                }
             

            }
        }
        else if (IsDrawWeapon == true)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                weapon1.SetActive(false);
                weapon2.SetActive(false);
                IsDrawWeapon = false;
            }

            if (Weapon == true)
            {
                speed = _speed;
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    weapon1.SetActive(true);
                    weapon2.SetActive(false);
                    Weapon = false;
                }
            }
            else if (Weapon == false)
            {
                speed = _speed;

                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    weapon1.SetActive(false);
                    weapon2.SetActive(true);
                    Weapon = true;
                }
            }            
        }
    }
}