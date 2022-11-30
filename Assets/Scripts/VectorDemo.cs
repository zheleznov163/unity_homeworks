using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///     Векторное сложение
/// </summary>

public class VectorDemo : MonoBehaviour
{
    public Vector3 V1;
    public Vector3 V2;

    public float resultLength;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.grey;
        VectorDemo.DrawVector(transform.position, V1);
        VectorDemo.DrawVector(transform.position, V2);

        Gizmos.color = Color.green;
        VectorDemo.DrawVector(transform.position, V1 + V2);
        Gizmos.color = Color.red;
        VectorDemo.DrawVector(transform.position + V2, (V1 - V2).normalized * resultLength);
    }

    private static void DrawVector(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector);
        Gizmos.DrawSphere(start + vector, .2f);
    }
}
