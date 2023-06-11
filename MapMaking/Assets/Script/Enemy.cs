using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target; // 쫓을 대상 (캐릭터)

    public float moveSpeed = 3f; // 이동 속도
    public float stoppingDistance = 1f; // 캐릭터와의 정지 거리

    private void Update()
    {
        if (target != null)
        {
            // 캐릭터를 향해 이동
            Vector2 direction = target.position - transform.position;
            float distance = direction.magnitude;

            if (distance > stoppingDistance)
            {
                direction.Normalize();
                transform.Translate(direction * moveSpeed * Time.deltaTime);
            }
        }

        float dis = transform.position.x - target.position.x;
        if(dis > 0)
        {

            transform.localScale = new Vector3(-1, 1, 1);
        }else if(dis < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}

