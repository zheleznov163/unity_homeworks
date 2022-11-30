using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CrossProduct : MonoBehaviour
{
    public Transform V1;
    public Transform V2;


    private void OnDrawGizmos()
    {
        if (V1 == null || V2 == null)
            return;

        Vector3 center = transform.position;
        Vector3 vector1 = V1.position;
        Vector3 vector2 = V2.position;

        Gizmos.color = Color.red;
        Draw(center, vector1);
        Gizmos.color = Color.green;
        Draw(center, vector2);

        Vector3 cross = Vector3.Cross(vector1, vector2);

        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(center, cross);
    }

    static void Draw(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector - start);
        Gizmos.DrawSphere(start, .2f);
    }
}
