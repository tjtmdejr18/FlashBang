using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    

    // ��ư�� Ŭ������ �� ȣ��Ǵ� �޼ҵ�
    public void ClickStart()
    {
        SceneManager.LoadScene("GameStage1");
    }
    public void ClickQuit()
    {
        Application.Quit();
    }
}


