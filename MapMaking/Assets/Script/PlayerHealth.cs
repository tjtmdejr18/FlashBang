using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public GameObject gameOverPanel; // 패널 오브젝트

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void ModifyHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void RecoverHealth(int amount)
    {
        ModifyHealth(amount);
    }

    void Die()
    {
        currentHealth = maxHealth;

        // 패널 활성화
        gameOverPanel.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            ModifyHealth(-10);
        }
        else if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            RecoverHealth(10);
        }
    }
}
