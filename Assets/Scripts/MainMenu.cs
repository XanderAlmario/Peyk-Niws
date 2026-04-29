using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] public LevelSO level;
    public void StartEasyGameFab()
    {
        SceneManager.LoadSceneAsync("EasyFabricated");
        level.inFab = true;
        level.inMis = false;
        level.inMan = false;
        level.inEasy = true;
        level.inHard = false;
        level.inEnd = false;
    }
    public void StartEasyGameMis()
    {
        SceneManager.LoadSceneAsync("EasyMisleading");
        level.inFab = false;
        level.inMis = true;
        level.inMan = false;
        level.inEasy = true;
        level.inHard = false;
        level.inEnd = false;
    }
    public void StartEasyGameMan()
    {
        SceneManager.LoadSceneAsync("EasyManipulated");
        level.inFab = false;
        level.inMis = false;
        level.inMan = true;
        level.inEasy = true;
        level.inHard = false;
        level.inEnd = false;
    }
    public void StartHardGameFab()
    {
        SceneManager.LoadSceneAsync("HardFabricated");
        level.inFab = true;
        level.inMis = false;
        level.inMan = false;
        level.inEasy = false;
        level.inHard = true;
        level.inEnd = false;
    }
    public void StartHardGameMis()
    {
        SceneManager.LoadSceneAsync("HardMisleading");
        level.inFab = false;
        level.inMis = true;
        level.inMan = false;
        level.inEasy = false;
        level.inHard = true;
        level.inEnd = false;
    }
    public void StartHardGameMan()
    {
        SceneManager.LoadSceneAsync("HardManipulated");
        level.inFab = false;
        level.inMis = false;
        level.inMan = true;
        level.inEasy = false;
        level.inHard = true;
        level.inEnd = false;
    }
    public void StartEndGameMan()
    {
        SceneManager.LoadSceneAsync("End");
        level.inFab = false;
        level.inMis = false;
        level.inMan = false;
        level.inEasy = false;
        level.inHard = false;
        level.inEnd = true;
    }

    public void StartTutorial()
    {
        SceneManager.LoadSceneAsync("FYP");
    }

    public void GoToLevSelect()
    {
        SceneManager.LoadSceneAsync("LevelSelect");
    }
}
