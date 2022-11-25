using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    public List<GameObject> Bombs;

    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject bomb in Bombs)
        {
            Bang bang = bomb.GetComponent<Bang>();
            bang.Explode();
        }
        Destroy(gameObject);
    }
}
