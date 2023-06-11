using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // �Ѿ� �߻縦 ���� ����
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 10f;

    // �÷��̾� ������Ʈ ������ ���� ����
    public GameObject playerObject;

    // ���� �߻� �ֱ�
    public float fireRate = 1f;
    private float nextFireTime = 0f;

    // ���� �÷��̾ ���� ȸ���� �ӵ�
    public float rotationSpeed = 5f;

    private void Update()
    {
        // �÷��̾ �����ϴ� ��쿡�� �߻�
        if (playerObject != null)
        {
            // �÷��̾� �������� ȸ��
            Vector3 direction = playerObject.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);

            // �߻� �ֱ⿡ ���� �Ѿ� �߻�
            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + fireRate;
                Fire();
            }
        }
    }

    // �Ѿ� �߻�
    private void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
    }
}

