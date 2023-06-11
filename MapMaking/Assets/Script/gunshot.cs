using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshot : MonoBehaviour
{
    public int damageAmount = 10;  // 총알의 데미지 양

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // 플레이어의 PlayerHealth 컴포넌트 가져오기
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                // 플레이어의 체력 수정
                playerHealth.ModifyHealth(-damageAmount);

                // 총알 삭제
                Destroy(gameObject);
            }
        }
    }
}


