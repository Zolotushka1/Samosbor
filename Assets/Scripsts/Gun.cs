using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Camera mainCamera;
    public Transform spawnerBullet;
    public float BulletSpeed;
    public float spread;

    void Update()
    {
        Shoot();
    }
    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
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
            currentBullet.transform.position = dirWithSpread.normalized;
            currentBullet.GetComponent<Rigidbody>().AddForce(dirWithSpread.normalized * BulletSpeed, ForceMode.Impulse);//добавить код пули и фиксануть код

        }
        
         
    }
}
