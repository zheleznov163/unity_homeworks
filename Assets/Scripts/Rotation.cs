using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 rotation;

    private void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(rotation * Time.deltaTime);
        transform.rotation = deltaRotation * transform.rotation;
    }
}
