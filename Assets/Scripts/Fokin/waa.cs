using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class waa : MonoBehaviour
{
    public float climbSpeed = 2.0f;
    public float raycastDistance = 100f;
    public LayerMask targetLayer;
    public TextMeshProUGUI displayText;
    public string customText = "Заданный текст";
    public Behaviour componentToDisable;
    private Rigidbody rb;
    [SerializeField]private Camera mainCamera;
    private bool isClimbing;
    public float moveSpeed = 5.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
        displayText.enabled = false;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        if (!isClimbing)
        {
            RaycastToScreenCenter();
            componentToDisable.enabled = true;
            rb.useGravity = true;
        }
        else
        {
            // Лезем по стене
            Vector3 climbDirection = new Vector3(horizontal, vertical, 0);
            transform.position += climbDirection * climbSpeed * Time.deltaTime;
            componentToDisable.enabled = false;
            rb.useGravity = false;
            displayText.enabled = false;
            if (Input.GetKeyDown(KeyCode.E))  
            {
                isClimbing = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isClimbing = false;
        }
        
    }

    void RaycastToScreenCenter()
    {
        Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance, targetLayer))
        {

            displayText.text = customText;
            displayText.enabled = true;
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                isClimbing = true;
            }
        }
        else
        {
            displayText.enabled = false;
        }
        
    }
}
