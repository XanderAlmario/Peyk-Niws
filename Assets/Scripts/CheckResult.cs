using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckResult : MonoBehaviour
{
    [SerializeField] public LevelSO level;
    [SerializeField] private PostSO postPerm;

    public void CheckForAkim()
    {
        if (level.inEasy)
        {
            if (postPerm.details == 2)
            {
                SceneManager.LoadSceneAsync("WinPage");
            }
            else
            {
                SceneManager.LoadSceneAsync("LosePage");
            }
        }
    }

    public void CheckForQymi()
    {
        if (level.inEasy)
        {
            SceneManager.LoadSceneAsync("LosePage");
        }
    }

    public void CheckForNikko()
    {
        if (level.inEasy)
        {
            SceneManager.LoadSceneAsync("LosePage");
        }
    }

    public void CheckForChris()
    {
        if (level.inEasy)
        {
            SceneManager.LoadSceneAsync("WinPage");
        }
    }

    public void CheckForJerd()
    {
        if (level.inEasy)
        {
            SceneManager.LoadSceneAsync("LosePage");
        }
    }

    public void CheckForSoph()
    {
        if (level.inEasy)
        {
            SceneManager.LoadSceneAsync("WinPage");
        }
    }
}
