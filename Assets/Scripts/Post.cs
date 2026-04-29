using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Post : MonoBehaviour
{
    [SerializeField] GameObject PFP;
    [SerializeField] TMP_Text username;
    [SerializeField] TMP_Text content;
    [SerializeField] GameObject post;
    [SerializeField] GameObject commentPFP;
    [SerializeField] TMP_Text clue;

    public void SetPostDetails(Sprite PFPImage, string username, string content, Sprite PostImage)
    {
        PFP.GetComponent<Image>().sprite = PFPImage;
        this.username.text = username;
        this.content.text = content;
        post.GetComponent<Image>().sprite = PostImage;
    }

    public void SetPostPopUpDetails(Sprite PFPImage, string username, string content, Sprite PostImage, string clue)
    {
        SetPostDetails(PFPImage, username, content, PostImage);
        commentPFP.GetComponent<Image>().sprite = PFPImage;
        this.clue.text = clue;
    }

    public void SetFriendButtonsDetails(Sprite PFPImage, string username)
    {
        PFP.GetComponent<Image>().sprite = PFPImage;
        this.username.text = username;
    }
}
