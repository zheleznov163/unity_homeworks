using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLog : MonoBehaviour
{
    public void Log()
    {
        Debug.Log("Button is Pressed");
    }

    public void LogInt(int value)
    {
        Debug.Log("Button is pressed " + value);
    }
}
