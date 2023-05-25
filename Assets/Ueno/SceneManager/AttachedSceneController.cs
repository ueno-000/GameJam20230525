using Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachedSceneController : MonoBehaviour
{
    void Start()
    {
        FadeScript.StartFadeIn();
    }
    public void ChangeScene(string target)
    {
        SceneChangeScript.LoadScene(target);
    }


    public void ChangeTitleScene()
    {
        SceneChangeScript.LoadScene(Define.SCENENAME_TITLE);
    }

    public void ChangeGameScene()
    {
        SceneChangeScript.LoadScene(Define.SCENENAME_MASTERGAME);
    }
    public void ChangeResultScene()
    {
        SceneChangeScript.LoadScene(Define.SCENENAME_RESULT);
    }

    public void Finish()
    {
        Application.Quit();
    }

}


