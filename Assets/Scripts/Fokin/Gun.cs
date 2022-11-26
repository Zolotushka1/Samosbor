using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int quantityBullet = 0;
    public int MaxQuantityBullet = 7;
    public GameObject bullet;
    public Camera mainCamera;
    public Transform spawnerBullet;
    public float BulletSpeed;
    public float spread;
    public AudioClip ShootMp3;
    public AudioSource _AudioSource;
    public ParticleSystem ShootEff;

    void Update()
    {
        Shoot();
           
    }
    private void Shoot()
    {
        
        if (Input.GetMouseButtonDown(0) &(quantityBullet != 0))
        {
            _AudioSource.PlayOneShot(ShootMp3);
            ShootEff.Play();
            quantityBullet -= 1;
           
            Ray ray = mainCamera.ViewportPointToRay(new Vector3(10f, 0, 0));
            RaycastHit hit;
            Vector3 targetPoint;
            if (Physics.Raycast(ray, out hit))
                targetPoint = hit.point;
            else
                targetPoint = ray.GetPoint(75);
            
            Vector3 dirWithoutSpread = targetPoint - spawnerBullet.position;
            float x = Random.Range(-spread, spread);
            float y = Random.Range(-spread, spread);
            Vector3 dirWithSpread = dirWithoutSpread + new Vector3( x, y, 0);
            GameObject currentBullet = Instantiate(bullet, spawnerBullet.position, Quaternion.identity);
            currentBullet.transform.forward = spawnerBullet.transform.forward;
            currentBullet.GetComponent<Rigidbody>().AddForce(spawnerBullet.transform.forward * BulletSpeed, ForceMode.Impulse);//добавить код пули и фиксануть код
            

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            quantityBullet = MaxQuantityBullet;
        }

    }    
}