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
        else if (level.inHard)
        {
            SceneManager.LoadSceneAsync("LosePage");
        }
        else if (level.inEnd)
        {
            SceneManager.LoadSceneAsync("Credits");
        }
    }

    public void CheckForQymi()
    {
        if (level.inEasy)
        {
            SceneManager.LoadSceneAsync("LosePage");
        }
        else if (level.inHard)
        {
            if (postPerm.details == 0)
            {
                SceneManager.LoadSceneAsync("WinPage");
            }
            else
            {
                SceneManager.LoadSceneAsync("LosePage");
            }
        }
        else if (level.inEnd)
        {
            SceneManager.LoadSceneAsync("Credits");
        }
    }

    public void CheckForNikko()
    {
        if (level.inEasy)
        {
            SceneManager.LoadSceneAsync("LosePage");
        }
        else if (level.inHard)
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
        else if (level.inEnd)
        {
            SceneManager.LoadSceneAsync("Credits");
        }
    }

    public void CheckForChris()
    {
        if (level.inEasy)
        {
            SceneManager.LoadSceneAsync("WinPage");
        }
        else if (level.inHard)
        {
            SceneManager.LoadSceneAsync("LosePage");
        }
        else if (level.inEnd)
        {
            SceneManager.LoadSceneAsync("Credits");
        }
    }

    public void CheckForJerd()
    {
        if (level.inEasy)
        {
            SceneManager.LoadSceneAsync("LosePage");
        }
        else if (level.inHard)
        {
            if (postPerm.details == 1)
            {
                SceneManager.LoadSceneAsync("WinPage");
            }
            else
            {
                SceneManager.LoadSceneAsync("LosePage");
            }
        }
        else if (level.inEnd)
        {
            SceneManager.LoadSceneAsync("Credits");
        }
    }

    public void CheckForSoph()
    {
        if (level.inEasy)
        {
            SceneManager.LoadSceneAsync("WinPage");
        }
        else if (level.inHard)
        {
            SceneManager.LoadSceneAsync("LosePage");
        }
    }
}
