using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Addition : MonoBehaviour
{
    public Transform V1;
    public Transform V2;

    private void OnDrawGizmos()
    {
        if (V1 == null || V2 == null)
            return;

        Vector3 start = transform.position;
        Vector3 vector1 = V1.position;
        Vector3 vector2 = V2.position;
        Vector3 sum =  (vector1 + vector2) - start;

        Gizmos.color = Color.grey;
        Draw(vector1, sum);
        Draw(vector2, sum);

        Gizmos.color = Color.red;
        Draw(start, vector1);

        Gizmos.color = Color.yellow;
        Draw(start, vector2);


        Gizmos.color = Color.green;
        Draw(start, sum);


    }

    private static void Draw(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector - start);
        Gizmos.DrawSphere(vector, .2f);
    }
}
