using Common;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// GameManager(スコア管理、制限時間)
/// </summary>
public class GameManager : MonoBehaviour
{
    public static float Time;

    public static bool IsGameOver;
  

    private GameManager _instance = default;
    private SceneManager _scene = default;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        _instance = this;
        SceneChangeScript.Changing = false;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == Define.SCENENAME_TITLE)
        {
            Time = 0;
            IsGameOver = false;
        }
        else if (SceneManager.GetActiveScene().name == Define.SCENENAME_MASTERGAME)
        {
            if (IsGameOver)
            {
                SceneChangeScript.LoadScene(Define.SCENENAME_RESULT);
            }
        }
        //if (SceneManager.GetActiveScene().name == Define.SCENENAME_RESULT)
        //{

        //}

    }

}

