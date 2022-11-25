using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogDoorOpen : MonoBehaviour
{
    public List<GameObject> Doors;

    private void OnTriggerEnter(Collider other)
    {
        if (Doors.Contains(other.gameObject)) Debug.Log(other.name + " закрыта");
    }

    private void OnTriggerExit(Collider other)
    {
        if (Doors.Contains(other.gameObject))  Debug.Log(other.name + " открыта");
    }
}
