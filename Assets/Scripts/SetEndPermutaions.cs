using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetEndPermutaions : MonoBehaviour
{
    [SerializeField] GameObject p1;
    [SerializeField] GameObject p2;
    [SerializeField] GameObject p3;
    [SerializeField] GameObject p4;
    [SerializeField] GameObject p5;

    [SerializeField] GameObject p1Popup;
    [SerializeField] GameObject p2Popup;
    [SerializeField] GameObject p3Popup;
    [SerializeField] GameObject p4Popup;
    [SerializeField] GameObject p5Popup;
    
    [SerializeField] GameObject FA;
    [SerializeField] GameObject KJ;
    [SerializeField] GameObject EN;
    [SerializeField] GameObject NC;
    [SerializeField] GameObject DQ;

    [SerializeField] GameObject friend1;
    [SerializeField] GameObject friend2;
    [SerializeField] GameObject friend3;
    [SerializeField] GameObject friend4;
    [SerializeField] GameObject friend5;

    [SerializeField] GameObject friendList1;
    [SerializeField] GameObject friendList2;
    [SerializeField] GameObject friendList3;
    [SerializeField] GameObject friendList4;
    [SerializeField] GameObject friendList5;

    [SerializeField] GameObject checkList;

    // GameObject test;
    GameObject[] perm = new GameObject[5];
    [SerializeField] public PostSO postPerm;
    [SerializeField] public LevelSO level;

    Sprite PFP1;
    Sprite PFP2;
    Sprite PFP3;
    Sprite PFP4;
    Sprite PFP5;

    string username1;
    string username2;
    string username3;
    string username4;
    string username5;

    string content1;
    string content2;
    string content3;
    string content4;
    string content5;

    Sprite postImage1;
    Sprite postImage2;
    Sprite postImage3;
    Sprite postImage4;
    Sprite postImage5;

    string clue1;
    string clue2;
    string clue3;
    string clue4;
    string clue5;

    void Start()
    {
        perm[0] = FA;
        perm[1] = KJ;
        perm[2] = EN;
        perm[3] = NC;
        perm[4] = DQ;

        friend1.transform.GetComponent<Button>().onClick.AddListener(() => friend1.GetComponent<Navigation>().GoToAkim());
        friend2.transform.GetComponent<Button>().onClick.AddListener(() => friend2.GetComponent<Navigation>().GoToJerd());
        friend3.transform.GetComponent<Button>().onClick.AddListener(() => friend3.GetComponent<Navigation>().GoToNikko());
        friend4.transform.GetComponent<Button>().onClick.AddListener(() => friend4.GetComponent<Navigation>().GoToChris());
        friend5.transform.GetComponent<Button>().onClick.AddListener(() => friend5.GetComponent<Navigation>().GoToQymi());

        friendList1.transform.GetComponent<Button>().onClick.AddListener(() => friendList1.GetComponent<Navigation>().GoToAkim());
        friendList2.transform.GetComponent<Button>().onClick.AddListener(() => friendList2.GetComponent<Navigation>().GoToJerd());
        friendList3.transform.GetComponent<Button>().onClick.AddListener(() => friendList3.GetComponent<Navigation>().GoToNikko());
        friendList4.transform.GetComponent<Button>().onClick.AddListener(() => friendList4.GetComponent<Navigation>().GoToChris());
        friendList5.transform.GetComponent<Button>().onClick.AddListener(() => friendList5.GetComponent<Navigation>().GoToQymi());

        SetPostDetails();
        SetPosts();
        SetPostPopUps();
        SetFriendButtons();
    }

    void SetPostDetails()
    {
        PFP1 = perm[0].transform.GetChild(0).GetComponent<Image>().sprite;
        PFP2 = perm[1].transform.GetChild(0).GetComponent<Image>().sprite;
        PFP3 = perm[2].transform.GetChild(0).GetComponent<Image>().sprite;
        PFP4 = perm[3].transform.GetChild(0).GetComponent<Image>().sprite;
        PFP5 = perm[4].transform.GetChild(0).GetComponent<Image>().sprite;

        username1 = perm[0].transform.GetChild(1).GetComponent<TMP_Text>().text;
        username2 = perm[1].transform.GetChild(1).GetComponent<TMP_Text>().text;
        username3 = perm[2].transform.GetChild(1).GetComponent<TMP_Text>().text;
        username4 = perm[3].transform.GetChild(1).GetComponent<TMP_Text>().text;
        username5 = perm[4].transform.GetChild(1).GetComponent<TMP_Text>().text;

        content1 = perm[0].transform.GetChild(2).GetComponent<TMP_Text>().text;
        content2 = perm[1].transform.GetChild(2).GetComponent<TMP_Text>().text;
        content3 = perm[2].transform.GetChild(2).GetComponent<TMP_Text>().text;
        content4 = perm[3].transform.GetChild(2).GetComponent<TMP_Text>().text;
        content5 = perm[4].transform.GetChild(2).GetComponent<TMP_Text>().text;

        postImage1 = perm[0].transform.GetChild(3).GetComponent<Image>().sprite;
        postImage2 = perm[1].transform.GetChild(3).GetComponent<Image>().sprite;
        postImage3 = perm[2].transform.GetChild(3).GetComponent<Image>().sprite;
        postImage4 = perm[3].transform.GetChild(3).GetComponent<Image>().sprite;
        postImage5 = perm[4].transform.GetChild(3).GetComponent<Image>().sprite;

        clue1 = perm[0].transform.GetChild(9).transform.GetChild(1).transform.GetChild(1).GetComponent<TMP_Text>().text;
        clue2 = perm[1].transform.GetChild(9).transform.GetChild(1).transform.GetChild(1).GetComponent<TMP_Text>().text;
        clue3 = perm[2].transform.GetChild(9).transform.GetChild(1).transform.GetChild(1).GetComponent<TMP_Text>().text;
        clue4 = perm[3].transform.GetChild(9).transform.GetChild(1).transform.GetChild(1).GetComponent<TMP_Text>().text;
        clue5 = perm[4].transform.GetChild(9).transform.GetChild(1).transform.GetChild(1).GetComponent<TMP_Text>().text;

        checkList.transform.GetChild(0).GetComponent<TMP_Text>().text = username1;
        checkList.transform.GetChild(1).GetComponent<TMP_Text>().text = username2;
        checkList.transform.GetChild(2).GetComponent<TMP_Text>().text = username3;
        checkList.transform.GetChild(22).GetChild(0).GetComponent<TMP_Text>().text = username4;
        checkList.transform.GetChild(22).GetChild(1).GetComponent<TMP_Text>().text = username5;
    }

    void SetPosts()
    {
        p1.GetComponent<Post>().SetPostDetails(PFP1, username1, content1, postImage1);
        p2.GetComponent<Post>().SetPostDetails(PFP2, username2, content2, postImage2);
        p3.GetComponent<Post>().SetPostDetails(PFP3, username3, content3, postImage3);
        p4.GetComponent<Post>().SetPostDetails(PFP4, username4, content4, postImage4);
        p5.GetComponent<Post>().SetPostDetails(PFP5, username5, content5, postImage5);
    }

    void SetPostPopUps()
    {
        p1Popup.GetComponent<Post>().SetPostPopUpDetails(PFP1, username1, content1, postImage1, clue1);
        p2Popup.GetComponent<Post>().SetPostPopUpDetails(PFP2, username2, content2, postImage2, clue2);
        p3Popup.GetComponent<Post>().SetPostPopUpDetails(PFP3, username3, content3, postImage3, clue3);
        p4Popup.GetComponent<Post>().SetPostPopUpDetails(PFP4, username4, content4, postImage4, clue4);
        p5Popup.GetComponent<Post>().SetPostPopUpDetails(PFP5, username5, content5, postImage5, clue5);
    }

    void SetFriendButtons()
    {
        friend1.GetComponent<Post>().SetFriendButtonsDetails(PFP1, username1);
        friend2.GetComponent<Post>().SetFriendButtonsDetails(PFP2, username2);
        friend3.GetComponent<Post>().SetFriendButtonsDetails(PFP3, username3);
        friend4.GetComponent<Post>().SetFriendButtonsDetails(PFP4, username4);
        friend5.GetComponent<Post>().SetFriendButtonsDetails(PFP5, username5);

        friendList1.GetComponent<Post>().SetFriendButtonsDetails(PFP1, username1);
        friendList2.GetComponent<Post>().SetFriendButtonsDetails(PFP2, username2);
        friendList3.GetComponent<Post>().SetFriendButtonsDetails(PFP3, username3);
        friendList4.GetComponent<Post>().SetFriendButtonsDetails(PFP4, username4);
        friendList5.GetComponent<Post>().SetFriendButtonsDetails(PFP5, username5);
    }

}
