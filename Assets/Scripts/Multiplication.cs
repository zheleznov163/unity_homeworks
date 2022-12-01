using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplication : MonoBehaviour
{
    public Transform V1;
    public Transform V2;

    private Vector3 start { get => transform.position; }
    private Vector3 vector1 { get => V1.position; }
    private Vector3 vector2 { get => V2.position; }
    private Vector3 cross { get => Vector3.Cross(vector1 - start, vector2 - start) ; }

    private void OnDrawGizmos()
    {
        if (V1 == null || V2 == null)
            return;

        Gizmos.color = Color.red;
        Draw(start, vector1 );
        Gizmos.color = Color.yellow;
        Draw(start, vector2);

        Gizmos.color = Color.green;
        Gizmos.DrawRay(start, cross);
    }

    private static void Draw(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector - start);
        Gizmos.DrawSphere(vector, .2f);
    }
}
