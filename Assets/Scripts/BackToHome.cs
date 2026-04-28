using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToHome : MonoBehaviour
{
    [SerializeField] public LevelSO level;
    public void goHome()
    {
        if (level.inFab && level.inEasy) SceneManager.LoadSceneAsync("EasyFabricated");
        else if (level.inMis && level.inEasy) SceneManager.LoadSceneAsync("EasyMisleading");
        else if (level.inMan && level.inEasy) SceneManager.LoadSceneAsync("EasyManipulated");
        else if (level.inFab && level.inHard) SceneManager.LoadSceneAsync("HardFabricated");
        else if (level.inMis && level.inHard) SceneManager.LoadSceneAsync("HardMisleading");
        else if (level.inMan && level.inHard) SceneManager.LoadSceneAsync("HardManipulated");
        else SceneManager.LoadSceneAsync("MainMenu");
    }
}
