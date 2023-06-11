using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public CharacterHealth characterHealth; // CharacterHealth 스크립트를 가진 객체
    public Text healthText; // UI 텍스트

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

        UpdateHealthUI(); // UI 업데이트
    }

    private void UpdateHealthUI()
    {
        healthText.text = "Health: " + characterHealth.currentHealth.ToString(); // 텍스트 업데이트
    }

    private void Update()
    {
        if (characterHealth != null && characterHealth.currentHealth != int.Parse(healthText.text.Substring(7)))
        {
            UpdateHealthUI(); // 체력이 변경되면 UI 업데이트
        }
    }
}
