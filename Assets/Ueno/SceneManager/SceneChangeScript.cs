using UnityEngine.SceneManagement;

public class SceneChangeScript
{
    private static bool roadNow = false;
    private static bool changing = false;

    public static bool Changing { get => changing; set => changing = value; }

    /// <summary>
    /// 指定シーンに移行する
    /// </summary>
    public static void LoadScene(string sceneName)
    {
        if (roadNow)
        {
            return;
        }
        roadNow = true;
        FadeScript.StartFadeOut(() => Load(sceneName));
    }
    public static void Load(string sceneName)
    {
        roadNow = false;
        SceneManager.LoadScene(sceneName);
        changing = true;
    }
}
