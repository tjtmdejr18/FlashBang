using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    

    // 滚瓢阑 努腐沁阑 锭 龋免登绰 皋家靛
    public void ClickStart()
    {
        SceneManager.LoadScene("GameStage1");
    }
    public void ClickQuit()
    {
        Application.Quit();
    }
    public void ingamequit()
    {
        SceneManager.LoadScene("Start");
    }
    public void howtomove()
    {
        SceneManager.LoadScene("조작법");
    }
    public void first()
    {
        SceneManager.LoadScene("CINEMA");
    }
}


