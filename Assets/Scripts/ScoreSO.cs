using UnityEngine;

[CreateAssetMenu(fileName = "ScoreSO", menuName = "Scriptable Objects/ScoreSO")]
public class ScoreSO : ScriptableObject
{
    [System.NonSerialized] private int myVar = 0;
    public int setScore
    {
        get { return myVar; }
        set { myVar = value; }
    }
    
}
