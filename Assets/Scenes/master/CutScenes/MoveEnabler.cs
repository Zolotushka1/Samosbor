using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveEnabler : MonoBehaviour
{
    private CharacterController characterControl;
    public bool enableController;
    private GameObject basedCamera;
    private HeadBob headBob;
    private Mouse_Control mouseMouve;
    private Player_Move playerMove;
    private GameObject cursorFind;
    private Canvas cursor;

    void Start()
    {
        basedCamera = GameObject.Find("Player_Camera");
        cursorFind = GameObject.Find("Cursor");
    }

    void Update()
    {
        characterControl = GetComponent<CharacterController>();
        mouseMouve = GetComponent<Mouse_Control>();
        playerMove = GetComponent<Player_Move>();
        headBob = basedCamera.GetComponent<HeadBob>();
        cursor = cursorFind.GetComponent<Canvas>();
        if (enableController == true)
        {
            cursor.enabled = true;
            characterControl.enabled = true;
            headBob.enabled = true;
            mouseMouve.enabled = true;
            playerMove.enabled = true;

        }
        else if (enableController == false)
        {
            cursor.enabled = false;
            characterControl.enabled = false;
            headBob.enabled = false;
            mouseMouve.enabled = false;
            playerMove.enabled = false;
        }
    }

}
