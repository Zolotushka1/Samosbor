using System.Collections;
using UnityEngine;

public class TriggerCheck2 : MonoBehaviour
{
    public GameObject targetObject;
    public float timer = 5f;
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !triggered)
        {
            triggered = true;
            targetObject.SetActive(true);
            StartCoroutine(RemoveTrigger());
        }
    }

    private IEnumerator RemoveTrigger()
    {
        yield return new WaitForSeconds(timer);
        targetObject.SetActive(false);
        Destroy(gameObject);
    }
}
