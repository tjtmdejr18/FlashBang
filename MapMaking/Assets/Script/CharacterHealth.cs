using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 100; // 최대 체력
    public int currentHealth; // 현재 체력

    private void Start()
    {
        currentHealth = maxHealth; // 시작 시 체력 초기화
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // 체력 감소

        if (currentHealth <= 0)
        {
            Die(); // 체력이 0 이하면 사망 처리
        }
    }

    private void Die()
    {
        // 사망 처리 로직을 구현하세요
        // 예를 들어, 게임 오버 화면을 표시하거나 게임을 재시작할 수 있습니다.
    }
}

