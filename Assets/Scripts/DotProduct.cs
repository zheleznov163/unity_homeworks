using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///     Скалярное произведение
/// </summary>
public class DotProduct : MonoBehaviour
{

    public Transform V1;
    public Transform V2;


    private void OnDrawGizmos()
    {
        if (V1 == null || V2 == null) return;

        Vector3 center = transform.position;
        Vector3 vector1 = V1.position;
        Vector3 vector2 = V2.position;

        Gizmos.color = Color.red;
        DotProduct.Draw(center,  vector1);
        Gizmos.color = Color.green;
        DotProduct.Draw(center,  vector2);

        float dot = Vector3.Dot(vector1.normalized, vector2.normalized);
        Color color = new Color(0f, 0f, 0f, 1f);
        if (dot > 0)
            color.g = dot;
        else
            color.r = -dot;

        Gizmos.color = color;
        Gizmos.DrawSphere(center, 1);

    }

    static void Draw(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector - start);
        Gizmos.DrawSphere(start, .2f);
    }
}
