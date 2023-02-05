using UnityEngine;
using UnityEngine.UI;

public class TriggerNotification : MonoBehaviour
{
    public GameObject notificationObject;
    public Text notificationText;
    public int triggerCounter = 0;
    private int maxTriggers = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && triggerCounter < maxTriggers)
        {
            notificationObject.SetActive(true);
            triggerCounter++;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            notificationObject.SetActive(false);
        }
    }
}
