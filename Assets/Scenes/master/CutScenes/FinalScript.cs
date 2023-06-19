using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FinalScript : MonoBehaviour
{
    [SerializeField] private GameObject afterSceneCanvas;
    [SerializeField] private float lenghtOfCutscene;
    public void OnActiv()
    {
        StartCoroutine(FinishCut());
    }
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(lenghtOfCutscene);
        afterSceneCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
}
