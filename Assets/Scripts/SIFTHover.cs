using UnityEngine;
using System.Collections;

public class SIFTHover : MonoBehaviour
{
    [SerializeField] GameObject SIFT;
    public void MouseEnter()
    {
        SIFT.SetActive(true);
    }
 
    public void MouseExit()
    {
        SIFT.SetActive(false);
    }
}
