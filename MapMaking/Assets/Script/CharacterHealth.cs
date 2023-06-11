using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 100; // �ִ� ü��
    public int currentHealth; // ���� ü��

    private void Start()
    {
        currentHealth = maxHealth; // ���� �� ü�� �ʱ�ȭ
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // ü�� ����

        if (currentHealth <= 0)
        {
            Die(); // ü���� 0 ���ϸ� ��� ó��
        }
    }

    private void Die()
    {
        // ��� ó�� ������ �����ϼ���
        // ���� ���, ���� ���� ȭ���� ǥ���ϰų� ������ ������� �� �ֽ��ϴ�.
    }
}

