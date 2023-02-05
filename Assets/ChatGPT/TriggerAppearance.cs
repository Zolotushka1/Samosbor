using UnityEngine;

public class TriggerAppearance : MonoBehaviour
{
    public Transform spawnLocation;
    public GameObject objectToSpawn;
    public AudioSource soundSource;
    public int triggerCount = 1;
    private int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && count < triggerCount)
        {
            count++;
            GameObject spawnedObject = Instantiate(objectToSpawn, spawnLocation.position, Quaternion.identity);
            soundSource.Play();
        }
    }
}