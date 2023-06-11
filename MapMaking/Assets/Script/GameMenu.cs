using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public GameObject panel; // 패널 게임 오브젝트

    private bool isPaused = false; // 일시정지 상태를 나타내는 변수

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame(); // 일시정지 해제
            }
            else
            {
                PauseGame(); // 일시정지
            }
        }
    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0; // 게임 시간을 멈춤
        panel.SetActive(true); // 패널을 활성화하여 보이게 함
    }

    void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1; // 게임 시간을 정상적으로 진행
        panel.SetActive(false); // 패널을 비활성화하여 숨김
    }
}
    
