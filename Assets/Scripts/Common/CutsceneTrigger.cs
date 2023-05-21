using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneTrigger : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject cutsceneCam;
    [SerializeField] private float lenghtOfCutscene;
    [SerializeField] private PlayableDirector director;

    private void OnTriggerEnter(Collider other)
    {
        director.GetComponent<PlayableDirector>().Play();
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        player.SetActive(false);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(lenghtOfCutscene);
        player.SetActive(true);
        cutsceneCam.SetActive(false);
    }
}
