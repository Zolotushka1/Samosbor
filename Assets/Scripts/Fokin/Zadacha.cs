using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Zadacha : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Missiontmp;
    [SerializeField] private string MissionText;
    public Collider Player;

    void OnTriggerEnter(Collider Player)
    {
        Missiontmp.text = MissionText;
    }
}
