using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlightObject;
    public GameObject flashlight;

    private Light flashlightLight;
    private bool flashlightOn = false;

    private void Start()
    {
        flashlightLight = flashlight.GetComponent<Light>();
        flashlightObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Invoke("TurnOnFlashlight", 1f);
        }
        if (flashlightOn)
        {
            flashlightObject.transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward);
        }
    }
    private void TurnOnFlashlight()
    {
        flashlightOn = !flashlightOn;
        flashlightLight.enabled = flashlightOn;
        flashlightObject.SetActive(flashlightOn);
        
    }
}

