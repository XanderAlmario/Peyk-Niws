using UnityEngine;

[CreateAssetMenu(fileName = "PostSO", menuName = "Scriptable Objects/PostSO")]
public class PostSO : ScriptableObject
{
    [System.NonSerialized] private int myVar = -1;

    public int details
    {
        get { return myVar; }
        set { myVar = value; }
    }
    
}
