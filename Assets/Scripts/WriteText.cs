using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class WriteText : MonoBehaviour
{
    [SerializeField] private GameObject soundToDelete;
    [SerializeField] private GameObject noteManager;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject menuManager;
    [SerializeField] private GameObject noteCanvas;
    [SerializeField] private GameObject cutsceneCam;
    [SerializeField] private GameObject finalScript;
    [SerializeField] private GameObject lastSamosbor;
    [SerializeField] private PlayableDirector director;
    [SerializeField] private float lenghtOfCutscene;
    [SerializeField] private GameObject[] DestroyOnOpen;

    [SerializeField] TMP_Text tmpProText;
    string writer;
    [SerializeField] private Coroutine coroutine;

    [SerializeField] float delayBeforeStart = 0f;
    [SerializeField] float timeBtwChars = 0.1f;
    [SerializeField] string leadingChar = "";
    [SerializeField] bool leadingCharBeforeDelay = false;
    [Space(10)][SerializeField] private bool startOnEnable = false;

    [Header("Collision-Based")]
    [SerializeField] private bool clearAtStart = false;
    enum options { clear, complete }
    [SerializeField] options collisionExitOptions;
    [TextArea (3,15)] public string  noteTexts_RU;
    [TextArea (3,15)] public string  noteTexts_ENG;

    void Awake()
    {
        if (Translator.LanguageId == 0)
        {
            tmpProText.text = noteTexts_RU;
            writer = tmpProText.text;
        }
        else if (Translator.LanguageId == 1)
        {
            tmpProText.text = noteTexts_ENG;
            writer = tmpProText.text;
        }
    }

    void Start()
    {
        if (!clearAtStart) return;
        if (tmpProText != null)
        {
            tmpProText.text = "";
        }
    }

    public void OnEnable()
    {
        menuManager.SetActive(false);
        noteManager.SetActive(true);
        var sounds = player.transform.GetChild(1).gameObject;
        sounds.SetActive(false);
        player.GetComponent<MoveEnabler>().enableController = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        foreach (GameObject ob in DestroyOnOpen)
        {
            ob.SetActive(false);
        }
        if (startOnEnable) StartTypewriter();
    }

    private void StartTypewriter()
    {
        StopAllCoroutines();

        if (tmpProText != null)
        {
            tmpProText.text = "";

            StartCoroutine("TypeWriterTMP");
        }
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }


    void Update()
    {
        /*if (Input.GetKey(KeyCode.E))
        {
            OnBtnClick();
        }*/
    }
    public void OnBtnClick()
    {
        soundToDelete.SetActive(false);
        lastSamosbor.SetActive(true);
        noteCanvas.SetActive(false);
        director.GetComponent<PlayableDirector>().Play();
        cutsceneCam.SetActive(true);
        player.SetActive(false);
        finalScript.GetComponent<FinalScript>().OnActiv();
    }

    IEnumerator TypeWriterTMP()
    {
        tmpProText.text = leadingCharBeforeDelay ? leadingChar : "";

        yield return new WaitForSeconds(delayBeforeStart);

        foreach (char c in writer)
        {
            if (tmpProText.text.Length > 0)
            {
                tmpProText.text = tmpProText.text.Substring(0, tmpProText.text.Length - leadingChar.Length);
            }
            tmpProText.text += c;
            tmpProText.text += leadingChar;
            yield return new WaitForSeconds(timeBtwChars);
        }

        if (leadingChar != "")
        {
            tmpProText.text = tmpProText.text.Substring(0, tmpProText.text.Length - leadingChar.Length);
        }
    }

}
