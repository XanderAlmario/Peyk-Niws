using UnityEngine;
using UnityEngine.UI;

public class CommentButton : MonoBehaviour
{
    public Button commentButton;
    public GameObject toClose;
    public GameObject toOpen;
    private void Start()
    {
        commentButton.onClick.AddListener(PopUp);
    }
    public void PopUp()
    {
        toClose.SetActive(false);
        toOpen.SetActive(true);
    }
}
