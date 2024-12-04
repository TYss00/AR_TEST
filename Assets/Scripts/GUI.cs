using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    public void MoveSceneZero()
    {
        SceneManager.LoadScene("AR Template Scene");
    }
    public void MoveSceneOne()
    {
        SceneManager.LoadScene("01_Basic_Face_Filter");
    }

    public void MoveSceneTwo()
    {
        SceneManager.LoadScene("02_Interactive_Face_Filter");
    }

    public void MoveSceneThree()
    {
        SceneManager.LoadScene("03_AR_Marker");
    }

    public void MoveSceneMain()
    {
        SceneManager.LoadScene("04_Final_Intro");
    }

    public void AppQuit()
    {
        Debug.Log("³ª°©´Ï´Ù.");
        Application.Quit();
    }
}
