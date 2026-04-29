using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] ScoreSO score;

    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "WinPage")
        {
            score.setScore += 100;
        }
    }
    
    void Start()
    {
        int currentScore = score.setScore;
        string scoreString = currentScore.ToString();
        scoreText.text = "Score: " + scoreString;
    }
}
