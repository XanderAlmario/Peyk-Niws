using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] public LevelSO level;
    public void StartGameFab()
    {
        SceneManager.LoadSceneAsync("EasyFabricated");
        level.inFab = true;
        level.inMis = false;
        level.inMan = false;
        level.inEasy = true;
        level.inHard = false;
    }
    public void StartGameMis()
    {
        SceneManager.LoadSceneAsync("EasyMisleading");
        level.inFab = false;
        level.inMis = true;
        level.inMan = false;
        level.inEasy = true;
        level.inHard = false;
    }
    public void StartGameMan()
    {
        SceneManager.LoadSceneAsync("EasyManipulated");
        level.inFab = false;
        level.inMis = false;
        level.inMan = true;
        level.inEasy = true;
        level.inHard = false;
    }
}
