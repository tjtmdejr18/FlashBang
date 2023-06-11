using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public int damage = 10;
    public float attackCooldown = 1f;
    public LayerMask enemyLayer;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public ParticleSystem attackEffect;
    public AudioClip attackSound;
    public AudioSource audioSource;

    private float attackTimer;
    private bool isAttacking;

    private void Update()
    {
        attackTimer += Time.deltaTime;

        if (Input.GetMouseButtonDown(1) && attackTimer >= attackCooldown && !isAttacking)
        {
            Attack();
            attackTimer = 0f;
        }
    }

    private void Attack()
    {
        isAttacking = true;

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        foreach (Collider2D enemy in hitEnemies)
        {
            if (enemy.CompareTag("Enemy"))
            {
                // 적에게 데미지를 입히는 코드
                EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(damage);
                }

                // 이펙트 생성
                Instantiate(attackEffect, attackPoint.position, Quaternion.identity);

                // 사운드 재생
                if (audioSource != null && attackSound != null)
                {
                    audioSource.PlayOneShot(attackSound);
                }
            }
        }

        isAttacking = false;
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
