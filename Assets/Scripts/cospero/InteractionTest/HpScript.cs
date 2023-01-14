using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HpScript : MonoBehaviour
{
    public int maxHealth = 100;
    public static int Health;
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
    public static void GetDamage(int DAMAge)
    {
        Health -= DAMAge;

    }
    void die()
    {
        if (Health < 1)
        {
            SceneManager.LoadScene(sceneL);
        }
    }
}
