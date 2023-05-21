using UnityEngine;
using TMPro;

public class Zadacha : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Missiontmp;
    [SerializeField] private string MissionText;
    [SerializeField] private TextMeshProUGUI NameMissiontmp;
    [SerializeField] private string NameMissionText;
    public Collider Player;

    void OnTriggerEnter(Collider Player)
    {
        Missiontmp.text = MissionText;
        NameMissiontmp.text = NameMissionText;
        //Destroy(gameObject);
    }
}
