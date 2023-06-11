using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    

    // 버튼을 클릭했을 때 호출되는 메소드
    public void ClickStart()
    {
        SceneManager.LoadScene("GameStage1");
    }
    public void ClickQuit()
    {
        Application.Quit();
    }
}


