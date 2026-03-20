using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public GameObject confirm;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        confirm.SetActive(false);
    }
    
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
    
    public void WinGame()
    {
        SceneManager.LoadSceneAsync("WinPage");
    }
    
    public void LoseGame()
    {
        SceneManager.LoadSceneAsync("LosePage");
    }

}
