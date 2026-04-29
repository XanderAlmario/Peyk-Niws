using UnityEngine;

[CreateAssetMenu(fileName = "LevelSO", menuName = "Scriptable Objects/LevelSO")]
public class LevelSO : ScriptableObject
{
    [System.NonSerialized] private bool fab = false;
    [System.NonSerialized] private bool mis = false;
    [System.NonSerialized] private bool man = false;
    [System.NonSerialized] private bool easy = false;
    [System.NonSerialized] private bool hard = false;
    [System.NonSerialized] private bool end = false;
    public bool inFab
    {
        get { return fab; }
        set { fab = value; }
    }
    public bool inMis
    {
        get { return mis; }
        set { mis = value; }
    }
    public bool inMan
    {
        get { return man; }
        set { man = value; }
    }
    public bool inEasy
    {
        get { return easy; }
        set { easy = value; }
    }
    public bool inHard
    {
        get { return hard; }
        set { hard = value; }
    }
    public bool inEnd
    {
        get { return end; }
        set { end = value; }
    }
    
}
