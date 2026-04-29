using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetPermutations : MonoBehaviour
{
    [SerializeField] GameObject p1;
    [SerializeField] GameObject p2;
    [SerializeField] GameObject p3;
    [SerializeField] GameObject p1Popup;
    [SerializeField] GameObject p2Popup;
    [SerializeField] GameObject p3Popup;
    [SerializeField] GameObject JS1;
    [SerializeField] GameObject DQ1;
    [SerializeField] GameObject EN1;
    [SerializeField] GameObject FA2;
    [SerializeField] GameObject NC2;
    [SerializeField] GameObject KJ2;
    [SerializeField] GameObject KJ3;
    [SerializeField] GameObject EN3;
    [SerializeField] GameObject FA3;
    [SerializeField] GameObject friend1;
    [SerializeField] GameObject friend2;
    [SerializeField] GameObject friend3;
    [SerializeField] GameObject friendList1;
    [SerializeField] GameObject friendList2;
    [SerializeField] GameObject friendList3;
    [SerializeField] GameObject checkList;

    
    GameObject[] firstPerm = new GameObject[3];
    GameObject[] secondPerm = new GameObject[3];
    GameObject[] thirdPerm = new GameObject[3];
    // GameObject test;
    GameObject[] perm = new GameObject[3];
    [SerializeField] public PostSO postPerm;
    [SerializeField] public LevelSO level;

    Sprite PFP1;
    Sprite PFP2;
    Sprite PFP3;

    string username1;
    string username2;
    string username3;

    string content1;
    string content2;
    string content3;

    Sprite postImage1;
    Sprite postImage2;
    Sprite postImage3;

    string clue1;
    string clue2;
    string clue3;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        firstPerm[0] = JS1;
        firstPerm[1] = DQ1;
        firstPerm[2] = EN1;
        
        secondPerm[0] = FA2;
        secondPerm[1] = NC2;
        secondPerm[2] = KJ2;

        thirdPerm[0] = KJ3;
        thirdPerm[1] = EN3;
        thirdPerm[2] = FA3;

        if (postPerm.details == -1) postPerm.details = Random.Range(0,3);

        if (postPerm.details == 0) 
        {
            perm = firstPerm;
            friend1.transform.GetComponent<Button>().onClick.AddListener(() => friend1.GetComponent<Navigation>().GoToSoph());
            friend2.transform.GetComponent<Button>().onClick.AddListener(() => friend2.GetComponent<Navigation>().GoToQymi());
            friend3.transform.GetComponent<Button>().onClick.AddListener(() => friend3.GetComponent<Navigation>().GoToNikko());

            friendList1.transform.GetComponent<Button>().onClick.AddListener(() => friendList1.GetComponent<Navigation>().GoToSoph());
            friendList2.transform.GetComponent<Button>().onClick.AddListener(() => friendList2.GetComponent<Navigation>().GoToQymi());
            friendList3.transform.GetComponent<Button>().onClick.AddListener(() => friendList3.GetComponent<Navigation>().GoToNikko());
        }
        else if (postPerm.details == 1) 
        {
            perm = secondPerm;
            friend1.transform.GetComponent<Button>().onClick.AddListener(() => friend1.GetComponent<Navigation>().GoToAkim());
            friend2.transform.GetComponent<Button>().onClick.AddListener(() => friend2.GetComponent<Navigation>().GoToChris());
            friend3.transform.GetComponent<Button>().onClick.AddListener(() => friend3.GetComponent<Navigation>().GoToJerd());

            friendList1.transform.GetComponent<Button>().onClick.AddListener(() => friendList1.GetComponent<Navigation>().GoToAkim());
            friendList2.transform.GetComponent<Button>().onClick.AddListener(() => friendList2.GetComponent<Navigation>().GoToChris());
            friendList3.transform.GetComponent<Button>().onClick.AddListener(() => friendList3.GetComponent<Navigation>().GoToJerd());
        }
        else if (postPerm.details == 2) 
        {
            perm = thirdPerm;
            friend1.transform.GetComponent<Button>().onClick.AddListener(() => friend1.GetComponent<Navigation>().GoToJerd());
            friend2.transform.GetComponent<Button>().onClick.AddListener(() => friend2.GetComponent<Navigation>().GoToNikko());
            friend3.transform.GetComponent<Button>().onClick.AddListener(() => friend3.GetComponent<Navigation>().GoToAkim());

            friendList1.transform.GetComponent<Button>().onClick.AddListener(() => friendList1.GetComponent<Navigation>().GoToJerd());
            friendList2.transform.GetComponent<Button>().onClick.AddListener(() => friendList2.GetComponent<Navigation>().GoToNikko());
            friendList3.transform.GetComponent<Button>().onClick.AddListener(() => friendList3.GetComponent<Navigation>().GoToAkim());
        }

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

        username1 = perm[0].transform.GetChild(1).GetComponent<TMP_Text>().text;
        username2 = perm[1].transform.GetChild(1).GetComponent<TMP_Text>().text;
        username3 = perm[2].transform.GetChild(1).GetComponent<TMP_Text>().text;

        content1 = perm[0].transform.GetChild(2).GetComponent<TMP_Text>().text;
        content2 = perm[1].transform.GetChild(2).GetComponent<TMP_Text>().text;
        content3 = perm[2].transform.GetChild(2).GetComponent<TMP_Text>().text;

        postImage1 = perm[0].transform.GetChild(3).GetComponent<Image>().sprite;
        postImage2 = perm[1].transform.GetChild(3).GetComponent<Image>().sprite;
        postImage3 = perm[2].transform.GetChild(3).GetComponent<Image>().sprite;

        clue1 = perm[0].transform.GetChild(9).transform.GetChild(1).transform.GetChild(1).GetComponent<TMP_Text>().text;
        clue2 = perm[1].transform.GetChild(9).transform.GetChild(1).transform.GetChild(1).GetComponent<TMP_Text>().text;
        clue3 = perm[2].transform.GetChild(9).transform.GetChild(1).transform.GetChild(1).GetComponent<TMP_Text>().text;

        checkList.transform.GetChild(0).GetComponent<TMP_Text>().text = username1;
        checkList.transform.GetChild(1).GetComponent<TMP_Text>().text = username2;
        checkList.transform.GetChild(2).GetComponent<TMP_Text>().text = username3;
    }

    void SetPosts()
    {
        p1.GetComponent<Post>().SetPostDetails(PFP1, username1, content1, postImage1);
        p2.GetComponent<Post>().SetPostDetails(PFP2, username2, content2, postImage2);
        p3.GetComponent<Post>().SetPostDetails(PFP3, username3, content3, postImage3);
    }

    void SetPostPopUps()
    {
        p1Popup.GetComponent<Post>().SetPostPopUpDetails(PFP1, username1, content1, postImage1, clue1);
        p2Popup.GetComponent<Post>().SetPostPopUpDetails(PFP2, username2, content2, postImage2, clue2);
        p3Popup.GetComponent<Post>().SetPostPopUpDetails(PFP3, username3, content3, postImage3, clue3);
    }

    void SetFriendButtons()
    {
        friend1.GetComponent<Post>().SetFriendButtonsDetails(PFP1, username1);
        friend2.GetComponent<Post>().SetFriendButtonsDetails(PFP2, username2);
        friend3.GetComponent<Post>().SetFriendButtonsDetails(PFP3, username3);

        friendList1.GetComponent<Post>().SetFriendButtonsDetails(PFP1, username1);
        friendList2.GetComponent<Post>().SetFriendButtonsDetails(PFP2, username2);
        friendList3.GetComponent<Post>().SetFriendButtonsDetails(PFP3, username3);
    }
}
