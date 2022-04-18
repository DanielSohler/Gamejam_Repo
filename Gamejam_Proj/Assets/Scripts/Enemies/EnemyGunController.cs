using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunController : MonoBehaviour
{
    public bool isFiring;

    public EnemyBulletController bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                EnemyBulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as EnemyBulletController;
                newBullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
    }
}