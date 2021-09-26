using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Test a = new Test();
}

[System.Serializable]
public class Test
{

    [Header("value")]
    public int month;
    public int year;
    public int day;
}