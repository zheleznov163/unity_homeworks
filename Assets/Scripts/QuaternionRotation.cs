using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionRotation : MonoBehaviour
{
    public Transform LookAt;
    public Vector3 RotationVelocity;
    public Vector3 Rotation;


    // Первый вариант преобразует углы в кватернионы. Те же проблемы остаются, просто пример чтобы понять как работает

    //void Update()
    //{
    //    //Quaternion deltaRotation = Quaternion.Euler(RotationVelocity * Time.deltaTime);

    //    //transform.rotation = deltaRotation * transform.rotation;
    //}

    // Поворот за другим объектом

    //private void Update()
    //{
    //    // Нормализованый вектор из центра в сторону направления
    //    Vector3 forward = (LookAt.position - transform.position).normalized;
    //    transform.rotation = Quaternion.LookRotation(forward);
    //}

    private void Update()
    {
        Vector3 forward = (LookAt.position - transform.position).normalized;
        forward = Quaternion.Euler(Rotation) * forward;
        transform.rotation = Quaternion.LookRotation(forward);
    }
}
