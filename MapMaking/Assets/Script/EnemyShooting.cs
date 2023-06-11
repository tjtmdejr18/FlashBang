using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform ������Ʈ
    public GameObject bulletPrefab; // �߻��� �Ѿ� ������
    public float shootingInterval = 2f; // �Ѿ� �߻� ����
    public float bulletSpeed = 5f; // �Ѿ� �ӵ�

    private float timeSinceLastShot; // ������ �Ѿ� �߻� ������ �ð�

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

            // �Ѿ� �߻� ������ ������ �Ѿ� �߻�
            if (timeSinceLastShot >= shootingInterval)
            {
                Shoot();
                timeSinceLastShot = 0f;
            }
        }
    }

    private void Shoot()
    {
        // �÷��̾� �������� �Ѿ� �߻�
        Vector2 direction = player.position - transform.position;
        direction.Normalize();

        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = direction * bulletSpeed;
    }
}

