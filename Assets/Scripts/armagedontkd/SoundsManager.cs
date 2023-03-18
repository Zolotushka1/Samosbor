using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    public AudioSource footstepSound;
    public AudioSource oneshotSounds;
    public AudioClip jumpclip;
    public AudioClip fallclip;
    public void Jump()
    {
        oneshotSounds.PlayOneShot(jumpclip);
    }

    public void StepsActive()
    {
        footstepSound.enabled = true;
    }

    public void StepsDeactive()
    {
        footstepSound.enabled = false;
    }

    public void Fall()
    {
        oneshotSounds.PlayOneShot(fallclip);
    }
}
