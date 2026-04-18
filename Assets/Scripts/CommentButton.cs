using UnityEngine;
using UnityEngine.UI;

public class CommentButton : MonoBehaviour
{
    public Button commentButton;
    public GameObject EN_BG;
    public GameObject EN_PopUp;
    private void Start()
    {
        commentButton.onClick.AddListener(PopUp);
    }
    public void PopUp()
    {
        EN_BG.SetActive(false);
        EN_PopUp.SetActive(true);
    }
}
