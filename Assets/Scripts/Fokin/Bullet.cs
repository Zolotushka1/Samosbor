using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletLife =1;
    private void Update()
    {
        Destroy(gameObject,BulletLife);
    }
}
