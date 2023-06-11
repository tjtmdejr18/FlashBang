using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // 총알 발사를 위한 변수
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 10f;

    // 플레이어 오브젝트 참조를 위한 변수
    public GameObject playerObject;

    // 적의 발사 주기
    public float fireRate = 1f;
    private float nextFireTime = 0f;

    // 적이 플레이어를 향해 회전할 속도
    public float rotationSpeed = 5f;

    private void Update()
    {
        // 플레이어가 존재하는 경우에만 발사
        if (playerObject != null)
        {
            // 플레이어 방향으로 회전
            Vector3 direction = playerObject.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);

            // 발사 주기에 따라 총알 발사
            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + fireRate;
                Fire();
            }
        }
    }

    // 총알 발사
    private void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
    }
}

