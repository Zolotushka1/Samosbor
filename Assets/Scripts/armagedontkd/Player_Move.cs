using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player_Move : MonoBehaviour
{
    [SerializeField] Slider staminaSlider;
    [SerializeField] float staminaValue;
    [SerializeField] float minValueStamina;
    [SerializeField] float maxValueStamina;
    [SerializeField] float staminaReturn;
    private TMP_Text textStamina;

    public bool AllStaminaSpentResently;
    public float speed_Move;
    public float speed_Run;
    public float speed_Current;
    public float MinStaminaForRun;
    public float jump;
    public float gravity = 1;
    float x_Move;
    float z_Move;
    CharacterController player;
    Vector3 move_Direction;

    
    void Start()
    {
        
        player = GetComponent<CharacterController>();
        textStamina = staminaSlider.transform.GetChild(3).GetComponent<TMP_Text>();
        AllStaminaSpentResently = false;
    }

    void Update()
    {
        Move();

        Stamina();
    }
    
    
    void Move()
    {
        x_Move = Input.GetAxis("Horizontal");
        z_Move = Input.GetAxis("Vertical");
        if(player.isGrounded)
        {
            move_Direction = new Vector3(x_Move, 0f, z_Move);
            move_Direction = transform.TransformDirection(move_Direction);
            if(Input.GetKey(KeyCode.Space))
            {
                move_Direction.y += jump;
            }
            if(Input.GetKey(KeyCode.LeftControl))
            {
                player.height = 1.4f;
            }
            else player.height = 1.8f;
        }
        move_Direction.y -= gravity;
        UnityEngine.Debug.Log(AllStaminaSpentResently);
        if ((Input.GetKey(KeyCode.LeftShift))&&(staminaValue>= staminaReturn) && (AllStaminaSpentResently==false))
        { 
            speed_Current = speed_Run;
            staminaValue -= staminaReturn * Time.deltaTime * 10;
        }
        else if((Input.GetKey(KeyCode.LeftShift)) && (staminaValue <= staminaReturn)&& (AllStaminaSpentResently==false))
        {
            AllStaminaSpentResently = true;
            staminaValue += staminaReturn * Time.deltaTime * 1f;
            speed_Current = speed_Move;
        }
        else if ((Input.GetKey(KeyCode.LeftShift)) && (AllStaminaSpentResently == true))
        {
            staminaValue += staminaReturn * Time.deltaTime * 2;
            if (staminaValue >= MinStaminaForRun)
            {
                AllStaminaSpentResently=false;
            }
        }
        else
        {
            speed_Current = speed_Move;
            staminaValue += staminaReturn * Time.deltaTime * 2;
            if (staminaValue > 100)
            {
                staminaValue = 100;
            }
        }
        player.Move(move_Direction * speed_Current * Time.deltaTime);
    }   
    private void Stamina()
    {
        if (maxValueStamina >= 100) maxValueStamina = 100f;
        if (maxValueStamina <= 100) maxValueStamina = 0f;
        textStamina.text = staminaSlider.value.ToString();
        staminaSlider.value = staminaValue;
    }
}
