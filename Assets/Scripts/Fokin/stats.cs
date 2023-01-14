using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stats : MonoBehaviour
{
    public float maxHealth = 100f;
    public static float Health;
    public int sceneL = 0;
    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        die();
    }
    public  void GetDamage(float DAMAge)
    {
        Health -= DAMAge;
        UnityEngine.Debug.Log(Health);
    }
    void die()
    {
        if (Health < 1)
        {
            SceneManager.LoadScene(sceneL);
        }
    }
}
