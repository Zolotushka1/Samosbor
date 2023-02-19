using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadButtonsScript : MonoBehaviour
{
    [SerializeField] GameObject CanvasObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            CanvasObj.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
