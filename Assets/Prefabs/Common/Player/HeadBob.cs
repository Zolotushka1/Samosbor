using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBob : MonoBehaviour
{
    public Animator camAnim;
    [SerializeField] private GameObject stats;
    public bool walking;
    public bool running;

    void Update()
    {
        var stats0 = stats.GetComponent<Player_Move>();
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            running = false;
            walking = true;
            camAnim.ResetTrigger("idle");
            camAnim.ResetTrigger("sprint");
            camAnim.SetTrigger("walk");
            if (walking)
            {
                if (walking & Input.GetKey(KeyCode.LeftShift) & stats0.AllStaminaSpentResently == false)
                {
                    running = true;
                    camAnim.ResetTrigger("walk");
                    camAnim.ResetTrigger("idle");
                    camAnim.SetTrigger("sprint");
                }
                else if (walking & Input.GetKey(KeyCode.LeftShift) & stats0.AllStaminaSpentResently == true)
                {
                    running = false;
                    camAnim.ResetTrigger("idle");
                    camAnim.ResetTrigger("sprint");
                    camAnim.SetTrigger("walk");
                }
            }
        }
        else
        {
            running = false;
            walking = false;
            camAnim.ResetTrigger("sprint");
            camAnim.ResetTrigger("walk");
            camAnim.SetTrigger("idle");
        }

    }
}
