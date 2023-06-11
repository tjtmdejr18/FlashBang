using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Text healthText;

    private void Start()
    {
        if (playerHealth == null)
        {
            Debug.LogError("PlayerHealth script is not assigned!");
            return;
        }

        if (healthText == null)
        {
            Debug.LogError("Health text is not assigned!");
            return;
        }

        UpdateHealthText();
    }

    private void UpdateHealthText()
    {
        healthText.text = "Health: " + playerHealth.currentHealth.ToString();
    }

    private void Update()
    {
        if (playerHealth != null && playerHealth.currentHealth != int.Parse(healthText.text.Substring(7)))
        {
            UpdateHealthText();
        }
    }

    public void SetPlayerHealth(PlayerHealth health)
    {
        playerHealth = health;
        UpdateHealthText();
    }
}
