using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MouseMove: MonoBehaviour
{
    float xRot;
    float yRot;
    float xRotCurrent;
    float yRotCurrent;
    public Camera player;
    public GameObject playerGameObject;
    public float sensitivity = 5f;
    public float SmoothTime = 0.1f;
    float currentVelosityX;
    float currentVelosityY;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        MouseMove();
    }
    
    void MouseMove()
    {
        xRot += Input.GetAxis("Mouse X") * sensitivity;
        yRot += Input.GetAxis("Mouse Y") * sensitivity;
        yRot = Mathf.Clamp(yRot, -90, 90);

        xRotCurrent = Mathf.SmoothDamp(xRotCurrent, xRot, ref currentVelosityX, SmoothTime);
        yRotCurrent = Mathf.SmoothDamp(yRotCurrent, yRot, ref currentVelosityY, SmoothTime);

        player.transform.rotation = Quaternion.Euler(-yRotCurrent, xRotCurrent, 0f);
        playerGameObject.transform.rotation = Quaternion.Euler(0f, xRotCurrent, 0f);    
    }
}
