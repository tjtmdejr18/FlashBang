using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform 컴포넌트
    public GameObject bulletPrefab; // 발사할 총알 프리팹
    public float shootingInterval = 2f; // 총알 발사 간격
    public float bulletSpeed = 5f; // 총알 속도

    private float timeSinceLastShot; // 마지막 총알 발사 이후의 시간

    private void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player Transform is not assigned!");
        }
    }

    private void Update()
    {
        if (player != null)
        {
            timeSinceLastShot += Time.deltaTime;

            // 총알 발사 간격이 지나면 총알 발사
            if (timeSinceLastShot >= shootingInterval)
            {
                Shoot();
                timeSinceLastShot = 0f;
            }
        }
    }

    private void Shoot()
    {
        // 플레이어 방향으로 총알 발사
        Vector2 direction = player.position - transform.position;
        direction.Normalize();

        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = direction * bulletSpeed;
    }
}

