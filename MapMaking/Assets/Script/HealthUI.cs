using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public CharacterHealth characterHealth; // CharacterHealth ��ũ��Ʈ�� ���� ��ü
    public Text healthText; // UI �ؽ�Ʈ

    private void Start()
    {
        if (characterHealth == null)
        {
            Debug.LogError("CharacterHealth script is not assigned!");
            return;
        }

        if (healthText == null)
        {
            Debug.LogError("Health text is not assigned!");
            return;
        }

        UpdateHealthUI(); // UI ������Ʈ
    }

    private void UpdateHealthUI()
    {
        healthText.text = "Health: " + characterHealth.currentHealth.ToString(); // �ؽ�Ʈ ������Ʈ
    }

    private void Update()
    {
        if (characterHealth != null && characterHealth.currentHealth != int.Parse(healthText.text.Substring(7)))
        {
            UpdateHealthUI(); // ü���� ����Ǹ� UI ������Ʈ
        }
    }
}
