using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{
    
    public void GoToNikko()
    {
        SceneManager.LoadSceneAsync("NikkoCharacterPage");
    }

    public void GoToChris()
    {
        SceneManager.LoadSceneAsync("ChrisCharacterPage");
    }

    public void GoToJerd()
    {
        SceneManager.LoadSceneAsync("JerdCharacterPage");
    }

    public void GoToSoph()
    {
        SceneManager.LoadSceneAsync("SophCharacterPage");
    }

    public void GoToQymi()
    {
        SceneManager.LoadSceneAsync("QymiCharacterPage");
    }

    public void GoToAkim()
    {
        SceneManager.LoadSceneAsync("AkimCharacterPage");
    }

    public void GoToFYP()
    {
        SceneManager.LoadSceneAsync("FYP");
    }

    public void GoToEasyFabricated()
    {
        SceneManager.LoadSceneAsync("EasyFabricated");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
    
    public void WinGame()
    {
        SceneManager.LoadSceneAsync("WinPage");
    }

    public void WinTutGame()
    {
        SceneManager.LoadSceneAsync("WinPageTut");
    }
    
    public void LoseGame()
    {
        SceneManager.LoadSceneAsync("LosePage");
    }

}
