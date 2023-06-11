using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemenubutton : MonoBehaviour
{
    public void clickquit()
    {
        SceneManager.LoadScene("Start"); // "StartScene"으로 이동
    }
}
