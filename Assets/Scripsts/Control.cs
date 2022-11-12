using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public static void GetDamage(float damage) {}

    private GameObject player;
    public float speed = 6;
    public float _speed;
    public int rotation = 250;
    public int jump = 3;
    public bool isGrounded;

    public static bool IsDrawWeapon;
    public static float x = 0.0f;

    void Start()
    {
        IsDrawWeapon = false;
        _speed = speed;
        player = (GameObject)this.gameObject;
    }

    void Update()
    {
        gun();
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void gun()
    {
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
        if (IsDrawWeapon == true)
        {
            speed = _speed * 2;
            if (Input.GetKey(KeyCode.Tab))
            {
                IsDrawWeapon = false;
            }
        }
        else if (IsDrawWeapon == false)
        {
            speed = _speed;

            if (Input.GetKey(KeyCode.Tab))
            {
                IsDrawWeapon = true;
            }
        }




    }

}
