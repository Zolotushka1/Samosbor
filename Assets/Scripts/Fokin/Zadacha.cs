using UnityEngine;
using TMPro;

public class Zadacha : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Missiontmp;
    [SerializeField] private TextMeshProUGUI NameMissiontmp;
    [SerializeField] private string MissionText_RU;
    [SerializeField] private string NameMissionText_RU;
    [SerializeField] private string MissionText_ENG;
    [SerializeField] private string NameMissionText_ENG;
    public Collider Player;

    void OnTriggerEnter(Collider Player)
    {
        if (Translator.LanguageId == 0)
        {
            Missiontmp.text = MissionText_RU;
            NameMissiontmp.text = NameMissionText_RU;   
        }
        else if (Translator.LanguageId == 1)
        {
            Missiontmp.text = MissionText_ENG;
            NameMissiontmp.text = NameMissionText_ENG;
        }
        //Destroy(gameObject);
    }
}
