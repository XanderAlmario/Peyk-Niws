using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultsPage : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadSceneAsync("JerdCharacterPage");
    }
}
