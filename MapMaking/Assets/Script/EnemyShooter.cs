using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public GameObject shootEffect; // 발사 시 사용할 이펙트 프리팹
    public float bulletSpeed = 5f;
    public float shootInterval = 2f;
    public float shootDistance = 10f; // 발사 거리

    private Transform player;
    private float shootTimer;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        shootTimer = shootInterval;
    }

    void Update()
    {
        shootTimer -= Time.deltaTime;

        if (shootTimer <= 0 && player != null)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            if (distanceToPlayer <= shootDistance)
            {
                Shoot();
            }

            shootTimer = shootInterval;
        }
    }

    void Shoot()
    {
        // 이펙트 생성
        Instantiate(shootEffect, firePoint.position, firePoint.rotation);

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        Vector2 direction = (player.position - firePoint.position).normalized;

        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
}
