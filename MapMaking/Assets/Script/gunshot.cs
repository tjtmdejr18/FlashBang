using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshot : MonoBehaviour
{
    public int damageAmount = 10;  // �Ѿ��� ������ ��

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // �÷��̾��� PlayerHealth ������Ʈ ��������
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                // �÷��̾��� ü�� ����
                playerHealth.ModifyHealth(-damageAmount);

                // �Ѿ� ����
                Destroy(gameObject);
            }
        }
    }
}


