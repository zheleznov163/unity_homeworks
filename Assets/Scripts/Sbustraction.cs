using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sbustraction : MonoBehaviour
{
    public Transform V1;
    public Transform V2;
    public TextMesh Text;

    private void OnDrawGizmos()
    {
        if (V1 == null || V2 == null)
            return;

        Vector3 start = transform.position;
        Vector3 vector1 = V1.position;
        Vector3 vector2 = V2.position;
        

        Gizmos.color = Color.green;
        Draw(vector1, vector2);

        Gizmos.color = Color.red;
        Draw(start, vector1);

        Gizmos.color = Color.yellow;
        Draw(start, vector2);

        Text.text = "Distance " + (vector2 - vector1).magnitude.ToString();
    }

    private static void Draw(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector - start);
        Gizmos.DrawSphere(vector, .2f);
    }
}
